using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Models.FigureModels;

public class Triangle : IShape
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        this._a = a;
        this._b = b;
        this._c = c;
    }
    
    /// <summary>
    /// Вычисление площади через формулу Герона.
    /// </summary>
    /// <returns>Возвращает площадь треугольника.</returns>
    public double GetArea()
    {
        double p = (_a + _b + _c) / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }
    /// <summary>
    /// Метод IsTriangleRectangular() проверяет, является ли треугольник прямоугольным.
    /// Он производит проверку по теореме Пифагора: для прямоугольного треугольника сумма квадратов длин двух катетов должна быть равна квадрату длины гипотенузы.
    /// </summary>
    /// <returns>Если условие верно, то метод возвращает true, иначе false.</returns>
    public bool IsTriangleRectangular()
    {
        return Math.Pow(_a, 2) + Math.Pow(_b, 2) == Math.Pow(_c, 2) ||
               Math.Pow(_a, 2) + Math.Pow(_c, 2) == Math.Pow(_b, 2) ||
               Math.Pow(_b, 2) + Math.Pow(_c, 2) == Math.Pow(_a, 2);
    }
}