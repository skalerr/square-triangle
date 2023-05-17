using ClassLibrary1.Models.FigureModels;
using NUnit.Framework;

namespace UnitTest;
[TestFixture]
public class ShapeTest
{
    [Test]
    public void TestCircleArea()
    {
        decimal expected = 78.5398163397448m;

        Circle c = new Circle(5);
        decimal actual = c.GetArea();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestTriangleArea()
    {
        decimal a = 3;
        decimal b = 4;
        decimal c = 5;
        decimal expected = 6;

        Triangle t = new Triangle(a, b, c);

        decimal actual = t.GetArea();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestRightTriangle()
    {
        decimal a = 3;
        decimal b = 4;
        decimal c = 5;
    
        bool expected = true;
        Triangle t = new Triangle(a, b ,c);

        bool actual = t.IsTriangleRectangular();
    
        Assert.AreEqual(expected, actual);
    }
}