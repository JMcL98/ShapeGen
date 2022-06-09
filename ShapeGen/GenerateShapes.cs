namespace ShapeGen;

public class GenerateShapes
{
    private readonly IGenerateRandomFeatures _generateRandomFeatures;
    private const int CanvasSize = 1000;

    public GenerateShapes(IGenerateRandomFeatures grf)
    {
        _generateRandomFeatures = grf;
    }

    public List<Shape> GetRandomShapes(int minShapes, int maxShapes)
    {
        var shapesList = new List<Shape>();
        
        var numShapes = _generateRandomFeatures.GetNumShapes(minShapes, maxShapes);
        var pointsPerShape = _generateRandomFeatures.GetNumPointsPerShape(numShapes);
        var newShapePoints = new List<Point>();

        for (var i = 0; i < numShapes; i++)
        {
            newShapePoints.Clear();
            var radius = _generateRandomFeatures.GetSeed((int)Math.Round(0.1 * CanvasSize), (int)Math.Round(0.4 * CanvasSize));
            var centrePoint = new Point(_generateRandomFeatures.GetSeed(radius, CanvasSize - radius), 
                _generateRandomFeatures.GetSeed(radius, CanvasSize - radius));

            for (var j = 0; j < pointsPerShape[i]; j++)
            {
                newShapePoints.Add(new Point((float)(centrePoint.GetX() + radius * Math.Cos(2 * Math.PI * j / pointsPerShape[i])),
                    (float)(centrePoint.GetY() + radius * Math.Sin(2 * Math.PI * j / pointsPerShape[i])))); 
            }
            
            shapesList.Add(new Shape(newShapePoints, _generateRandomFeatures.Aliased()));
        }

        return shapesList;
    }
}