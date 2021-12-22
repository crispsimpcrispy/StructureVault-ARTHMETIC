namespace Arithmetic.Core.Mathematics;

public class Interpolation
{
    public static double InterpolateLinear(double x0, double y0, double x1, double y1, double x)
    {
        double b = y0 + (x - x0) * (y1 - y0) / (x1 - x0);
        return b;
    }
}