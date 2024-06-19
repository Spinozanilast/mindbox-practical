using Geometry.Figures;

namespace Geometry.Tests;

/// <summary>
/// Модульные тесты для класса Circle
/// </summary>
public class CircleTests
{
    [Theory]
    [InlineData(0.0)]
    [InlineData(-5.0)]
    public void TestCircleArea_InvalidRadius_ThrowsArgumentException(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }


    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(10, 100 * Math.PI)]
    public void TestCircleArea(double radius, double expectedArea)
    {
        var circle = new Circle(radius);
        var area = circle.CalculateArea();
        Assert.Equal(expectedArea, area, 1e-10);
    }

}
