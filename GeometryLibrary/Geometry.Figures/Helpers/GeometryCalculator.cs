namespace Geometry.Figures;

/// <summary>
/// Класс предоставляет методы для работы с геометрическими фигурами.
/// </summary>
public class GeometryCalculator : IAreaCalculator
{
    /// <summary>
    /// Метод CalculateArea вычисляет площадь заданной геометрической фигуры.
    /// </summary>
    /// <param name="shape">Геометрическая фигура, для которой нужно вычислить площадь.</param>
    /// <returns>Возвращает площадь геометрической фигуры.</returns>
    public double CalculateArea(GeometricShape shape) => shape.CalculateArea();

    /// <summary>
    /// Метод IsRightTriangle проверяет, является ли заданный треугольник прямоугольным.
    /// </summary>
    /// <param name="triangle">Треугольник, который нужно проверить.</param>
    /// <returns>Возвращает true, если треугольник прямоугольный, иначе false.</returns>
    public bool IsRightTriangle(Triangle triangle, double tolerance = 1e-10)
    {
        return triangle.IsRightTriangle(tolerance);
    }
}
