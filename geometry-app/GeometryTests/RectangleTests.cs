using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void TestArea()
    {
        var rectangle = new Rectangle(5, 3);

        
        var result = rectangle.CalculateArea();

        
        Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        var rectangle = new Rectangle(5, 3);

        var result = rectangle.CalculatePerimeter();

    
        Assert.AreEqual(16, result);
    }
}