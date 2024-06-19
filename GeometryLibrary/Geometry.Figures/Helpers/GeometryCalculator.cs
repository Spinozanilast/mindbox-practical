namespace Geometry.Figures;

public class GeometryCalculator : IAreaCalculator
{
    public bool IsRightTriangle(Triangle triangle)
    {
        return triangle.IsRightTriangle();
    }
}
