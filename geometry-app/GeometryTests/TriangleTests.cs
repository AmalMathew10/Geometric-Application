using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TestArea()
    {
        var triangle = new Triangle(5, 3);

        var result = triangle.CalculateArea();

        
        Assert.AreEqual(7.5, result, delta: 0.01);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        
        var triangle = new Triangle(5, 3);

       
        var result = triangle.CalculatePerimeter();


        Assert.AreEqual(15, result);
    }
}