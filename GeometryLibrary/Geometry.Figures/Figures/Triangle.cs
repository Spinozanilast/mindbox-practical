using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;

namespace Geometry.Figures;

public class Triangle : GeometricShape
{
    public double SideA { get; init; }
    public double SideB { get; init; }
    public double SideC { get; init; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!AreValidSideLengths(sideA, sideB, sideC))
            throw new ArgumentException("Переданы не валидные значения сторон треугольника (должны быть больше нуля)");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightTriangle(double tolerance = 1e-10)
    {
        double a = SideA * SideA;
        double b = SideB * SideB;
        double c = SideC * SideC;

        return Math.Abs(a + b - c) < tolerance ||
               Math.Abs(a + c - b) < tolerance ||
               Math.Abs(b + c - a) < tolerance;
    }

    private bool AreValidSideLengths(double sideA, double sideB, double sideC) => sideA > 0 && sideB > 0 && sideC > 0;

}
