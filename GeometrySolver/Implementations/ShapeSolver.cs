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


// SELECT Product.Name, Category.Name
//     FROM Product
//     LEFT JOIN ProductCategory ON Product.ID = ProductCategory.ProductID
// LEFT JOIN Category ON ProductCategory.CategoryID = Category.ID
// Этот запрос использует LEFT JOIN, чтобы включить в результат все продукты, даже если у них нет соответствующей категории.
// Он соединяет таблицы Product, ProductCategory и Category, чтобы получить имена продуктов и категорий.