using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Models.FigureModels;

public class Triangle : IShape
{
    private readonly decimal _a;
    private readonly decimal _b;
    private readonly decimal _c;

    public Triangle(decimal a, decimal b, decimal c)
    {
        this._a = a;
        this._b = b;
        this._c = c;
    }
    
    /// <summary>
    /// Вычисление площади через формулу Герона.
    /// </summary>
    /// <returns>Возвращает площадь треугольника.</returns>
    public decimal GetArea()
    {
        decimal p = (_a + _b + _c) / 2;
        return (decimal) Math.Sqrt((double) (p * (p - _a) * (p - _b) * (p - _c)));
    }
    /// <summary>
    /// Метод IsTriangleRectangular() проверяет, является ли треугольник прямоугольным.
    /// Он производит проверку по теореме Пифагора: для прямоугольного треугольника сумма квадратов длин двух катетов должна быть равна квадрату длины гипотенузы.
    /// </summary>
    /// <returns>Если условие верно, то метод возвращает true, иначе false.</returns>
    public bool IsTriangleRectangular()
    {
        return  (_a * _a + _b * _b == _c * _c) 
                || (_a * _a + _c * _c == _b * _b) 
                || (_b * _b + _c * _c == _a * _a);
    }
    
}