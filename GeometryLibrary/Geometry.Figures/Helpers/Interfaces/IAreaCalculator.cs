namespace Geometry.Figures;

/// <summary>
/// Интерфейс IAreaCalculator предоставляет метод для расчета площади геометрической фигуры.
/// </summary>
public interface IAreaCalculator
{
    /// <summary>
    /// Метод CalculateArea вычисляет площадь заданной геометрической фигуры.
    /// </summary>
    /// <param name="shape">Геометрическая фигура, для которой нужно вычислить площадь.</param>
    public double CalculateArea(GeometricShape shape);
}
