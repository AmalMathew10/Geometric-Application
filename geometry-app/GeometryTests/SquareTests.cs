using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

[TestClass]
public class SquareTests
{
    [TestMethod]
    public void TestArea()
    {
        var square = new Square(5);

        var result = square.CalculateArea();

        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        var square = new Square(5);

        var result = square.CalculatePerimeter();

        Assert.AreEqual(20, result);
    }
}