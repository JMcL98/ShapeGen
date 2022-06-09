namespace ShapeGen;

public class ReturnedPoint
{
    public decimal X { get; set; }
    public decimal Y { get; set; }

    public ReturnedPoint(decimal x, decimal y)
    {
        X = Decimal.Round(x, 2);
        Y = Decimal.Round(y, 2);
    }
}