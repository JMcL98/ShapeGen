namespace ShapeGen;

public class GenerateFeatures1 : IGenerateRandomFeatures
{
    private Random rng;
    private int _numShapes = -1;
    private readonly int _shapeCeiling = 10;
    private readonly int _pointCeiling = 25;

    public GenerateFeatures1()
    {
        rng = new Random();
    }
    
    public int GetNumShapes(int min, int max)
    {
        if (min < 1)
            throw new ArgumentException("Minimum must be at least 1");
        
        
        _numShapes = rng.Next(min < _shapeCeiling ? min : _shapeCeiling, max < _shapeCeiling ? max : _shapeCeiling);
        return _numShapes;
    }

    public int[] GetNumPointsPerShape(int num)
    {
        var numPoints = new int[num < _pointCeiling ? num : _pointCeiling];
        for (var i = 0; i < num; i++)
        {
            numPoints[i] = rng.Next(3, 10);
        }

        return numPoints;
    }

    public int GetSeed(int max)
    {
        return rng.Next(1, max);
    }

    public bool Aliased()
    {
        return rng.Next(1, 2) == 1;
    }
}