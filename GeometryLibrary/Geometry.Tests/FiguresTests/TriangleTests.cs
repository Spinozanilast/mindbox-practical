using Geometry.Figures;

namespace Geometry.Tests;

/// <summary>
/// Модульные тесты для класса Triangle
/// </summary>
public class TriangleTests
{
    [Theory]
    [InlineData(0, 3, 4)]
    [InlineData(-3.0, 3.0, 4.0)]
    public void TestTriangleArea_InvalidSides_ThrowsArgumentException(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(6, 10, 8, 24)]
    public void TestTriangleArea(double sideA, double sideB, double sideC, double expectedArea)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        var area = triangle.CalculateArea();
        Assert.Equal(expectedArea, area, 1e-10);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(6, 8, 9, false)]
    public void TestTriangleIsRightTriangle(double sideA, double sideB, double sideC, bool expectedResult)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        var isRightTriangle = triangle.IsRightTriangle();
        Assert.Equal(expectedResult, isRightTriangle);
    }
}
