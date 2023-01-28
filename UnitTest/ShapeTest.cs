using ClassLibrary1.Models.FigureModels;
using NUnit.Framework;

namespace UnitTest;

[TestFixture]
public class ShapeTest
{
    [Test]
    public void TestCircleArea()
    {
        Circle c = new Circle(5);
        Assert.AreEqual(78.53981633974483, c.GetArea(), 0.001);
    }

    [Test]
    public void TestTriangleArea()
    {
        Triangle t = new Triangle(3, 4, 5);
        Assert.AreEqual(6, t.GetArea(), 0.001);
    }
    [Test]
    public void TestIsRight()
    {
        Triangle t = new Triangle(3, 4, 5);
        Assert.IsTrue(t.IsTriangleRectangular());
    }
}