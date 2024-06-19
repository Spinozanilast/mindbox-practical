namespace Geometry.Figures;

public class Circle : GeometricShape
{
    public double Radius { get; init; }

    public Circle(double radius)
    {
        if (radius <= 0) throw new ArgumentException("Передан не валидный радиус (должен быть больше нуля)");
        Radius = radius;
    }

    public override double CalculateArea() => Math.PI * Radius * Radius;
}
