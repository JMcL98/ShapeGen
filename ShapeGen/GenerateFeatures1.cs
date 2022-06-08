namespace ShapeGen;

public class GenerateFeatures1 : IGenerateRandomFeatures
{
    private Random rng;
    private int NumShapes = -1;

    public GenerateFeatures1()
    {
        rng = new Random();
    }
    
    public int GetNumShapes()
    {
        NumShapes = rng.Next(1, 5);
        return NumShapes;
    }

    public int[] GetNumPointsPerShape(int num)
    {
        var numPoints = new int[num];
        for (var i = 0; i < num; i++)
        {
            numPoints[i] = rng.Next(3, 10);
        }

        return numPoints;
    }

    public int GetSeed()
    {
        return rng.Next();
    }

    public bool Aliased()
    {
        return rng.Next(1, 2) == 1;
    }
}