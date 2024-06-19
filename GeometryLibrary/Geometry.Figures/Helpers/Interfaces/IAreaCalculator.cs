namespace Geometry.Figures;

public interface IAreaCalculator
{
    public double CalculateArea(GeometricShape shape)
    {
        return shape.CalculateArea();
    }
}
