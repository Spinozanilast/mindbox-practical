using Geometry.Figures;
using Xunit;

namespace Geometry.Tests;

/// <summary>
/// Модульные тесты для класса GeometryCalculator
/// </summary>
public class GeometryCalculatorTests
{
    [Fact]
    public void TestIsRightTriangle_True()
    {
        var triangle = new Triangle(3, 4, 5);
        var calculator = new GeometryCalculator();

        var result = calculator.IsRightTriangle(triangle);

        Assert.True(result);
    }

    [Fact]
    public void TestIsRightTriangle_False()
    {
        var triangle = new Triangle(6, 8, 9);
        var calculator = new GeometryCalculator();

        var result = calculator.IsRightTriangle(triangle);

        Assert.False(result);
    }

    [Fact]
    public void TestCalculateArea_Circle()
    {
        var circle = new Circle(5);
        var calculator = new GeometryCalculator();

        var area = calculator.CalculateArea(circle);

        Assert.Equal(Math.PI * 25, area, 1e-10);
    }

    [Fact]
    public void TestCalculateArea_Triangle()
    {
        var triangle = new Triangle(3, 4, 5);
        var calculator = new GeometryCalculator();

        var area = calculator.CalculateArea(triangle);

        Assert.Equal(6, area, 1e-10);
    }
}
