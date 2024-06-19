namespace Geometry.Figures;

public class Triangle : GeometricShape
{
    public double SideA { get; init; }
    public double SideB { get; init; }
    public double SideC { get; init; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightTriangle()
    {
        double a = SideA * SideA;
        double b = SideB * SideB;
        double c = SideC * SideC;
        return a + b == c || a + c == b || b + c == a;
    }
}
