namespace ShapeGen;

public interface IGenerateRandomFeatures
{
    int GetNumShapes();

    int[] GetNumPointsPerShape(int num);

    int GetSeed();
    
    bool Aliased();
}