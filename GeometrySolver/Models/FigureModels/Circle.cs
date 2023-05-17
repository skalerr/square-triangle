using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Models.FigureModels;

public class Circle : IShape
{
    private readonly decimal _radius;

    public Circle(decimal radius)
    {
        this._radius = radius;
    }

    /// <summary>
    /// Вычисляет значение площади круга с помощью формулы площади круга PI*R^2.
    /// </summary>
    /// <returns>Возвращает значение площади круга.</returns>
    public decimal GetArea()
    {
        return new decimal(Math.PI * Math.Pow((double) _radius, 2));
    }
}