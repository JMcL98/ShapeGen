namespace ShapeGen;

public class ReturnedPoint
{
    public decimal X;
    public decimal Y;

    public ReturnedPoint(decimal x, decimal y)
    {
        X = Decimal.Round(x, 2);
        Y = Decimal.Round(y, 2);
    }
}