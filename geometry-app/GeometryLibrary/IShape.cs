public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}
public class Square : IShape
{
    private double _sideLength;

    public Square(double sideLength)
    {
        _sideLength = sideLength;
    }

    public double CalculateArea()
    {
        return _sideLength * _sideLength;
    }

    public double CalculatePerimeter()
    {
        return 4 * _sideLength;
    }
}

public class Rectangle : IShape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public double CalculateArea()
    {
        return _length * _width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (_length + _width);
    }
}

public class Triangle : IShape
{
    private double _base;
    private double _height;

    public Triangle(double @base, double height)
    {
        _base = @base;
        _height = height;
    }

    public double CalculateArea()
    {
        return 0.5 * _base * _height;
    }

    public double CalculatePerimeter()
    {
        return 3 * (_base);
    }
}