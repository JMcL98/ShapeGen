namespace ShapeGen;

public class GenerateShapes
{
    private readonly IGenerateRandomFeatures _generateRandomFeatures;

    public GenerateShapes(IGenerateRandomFeatures grf)
    {
        _generateRandomFeatures = grf;
    }

    public List<Shape> GetRandomShapes()
    {
        var shapesList = new List<Shape>();
        
        var numShapes = _generateRandomFeatures.GetNumShapes();
        var pointsPerShape = _generateRandomFeatures.GetNumPointsPerShape(numShapes);
        var newShapePoints = new List<Point>();

        for (var i = 0; i < numShapes; i++)
        {
            newShapePoints.Clear();
            var centrePoint = new Point(_generateRandomFeatures.GetSeed(10000) / 100, 
                _generateRandomFeatures.GetSeed(10000) / 100);
            var size = _generateRandomFeatures.GetSeed(100);

            for (var j = 0; j < pointsPerShape[i]; j++)
            {
                newShapePoints.Add(new Point((float)(centrePoint.GetX() + size * Math.Cos(2 * Math.PI * j / pointsPerShape[i])),
                    (float)(centrePoint.GetY() + size * Math.Sin(2 * Math.PI * j / pointsPerShape[i])))); 
            }
            
            shapesList.Add(new Shape(newShapePoints));
        }

        return shapesList;
    }
}