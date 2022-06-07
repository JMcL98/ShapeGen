namespace ShapeGen;

public class Shape
{
    private List<Point> Points;

    public Shape(List<Point> points)
    {
        Points = new List<Point>();
        foreach (var point in points)
        {
            Points.Add(point);
        }
    }

    public List<Point> GetAllPoints()
    {
        return Points;
    }
}