namespace ShapeGen;

public class Shape
{
    private List<Point> Points;
    private bool Aliased;

    public Shape(List<Point> points, bool aliased)
    {
        Points = new List<Point>();
        foreach (var point in points)
        {
            Points.Add(point);
        }

        Aliased = aliased;
    }

    public List<Point> GetAllPoints()
    {
        return Points;
    }

    public bool GetAliased()
    {
        return Aliased;
    }
}