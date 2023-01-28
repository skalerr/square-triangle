using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Models.FigureModels;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        this._radius = radius;
    }

    /// <summary>
    /// Вычисляет значение площади круга с помощью формулы площади круга PI*R^2.
    /// </summary>
    /// <returns>Возвращает значение площади круга.</returns>
    public double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}