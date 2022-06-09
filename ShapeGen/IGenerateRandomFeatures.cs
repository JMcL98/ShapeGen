namespace ShapeGen;

public interface IGenerateRandomFeatures
{
    int GetNumShapes(int min, int max);

    int[] GetNumPointsPerShape(int num);

    int GetSeed(int max);
    
    int GetSeed(int min, int max);
    
    bool Aliased();
}