namespace Geometry.Figures;

public class Circle : GeometricShape
{
    public double Radius { get; init; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea() => Math.PI * Radius * Radius;
}
