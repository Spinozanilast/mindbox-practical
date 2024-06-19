namespace Geometry.Figures;

/// <summary>
/// Абстрактный класс геометрической фигуры.
/// </summary>
public abstract class GeometricShape
{
    /// <summary>
    /// Метод для расчётов площади фигуры.
    /// </summary>
    /// <returns>Площадь фигуры</returns>
    public abstract double CalculateArea();
}
