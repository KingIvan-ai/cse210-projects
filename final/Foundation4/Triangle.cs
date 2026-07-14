public class Triangle : Shape
{
    private double _base;
    private double _height;
    private double _side1;
    private double _side2;
    private double _side3;

    public Triangle(string color, double triBase, double height, double side1, double side2, double side3) : base(color)
    {
        _base = triBase;
        _height = height;
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }

    public override double GetArea()
    {
        return 0.5 * _base * _height;
    }

    public override double GetPerimeter()
    {
        return _side1 + _side2 + _side3;
    }
}