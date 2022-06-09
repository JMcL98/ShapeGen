
namespace ShapeGen;

public class ReturnedShape
{
    public List<ReturnedPoint> Points { get; set; }
    public int NumPoints { get; set; }
    public bool Aliased { get; set; }
    
    public ReturnedShape(List<Point> points)
    {
        NumPoints = points.Count;
        Points = new List<ReturnedPoint>();
        foreach (var point in points)
        {
            Points.Add(new ReturnedPoint((decimal)point.GetX(), (decimal)point.GetY()));
        }
    }
}