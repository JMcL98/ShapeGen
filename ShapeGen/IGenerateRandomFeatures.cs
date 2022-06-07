namespace ShapeGen;

public interface IGenerateRandomFeatures
{
    int GetNumShapes();

    int[] GetNumPointsPerShape();

    int GetSeed();
    
    bool Aliased();
}