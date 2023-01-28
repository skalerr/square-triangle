using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Implementations
{
    public class ShapeCalculator
    {
        /// <summary>
        /// Метод для получения площади фигуры.
        /// </summary>
        /// <param name="shape">Объект интерфейса IShape</param>
        /// <returns>Возвращает значение площади.</returns>
        public double GetArea(IShape shape)
        {
            return shape.GetArea();
        }
    }
}

