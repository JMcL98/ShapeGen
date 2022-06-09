namespace ShapeGen;

public class Point
{
    private float X;
    private float Y;

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }

    public float GetX()
    {
        return X;
    }
    
    public float GetY()
    {
        return Y;
    }

    public float[] GetPoints()
    {
        return new float[] { X, Y };
    }
}