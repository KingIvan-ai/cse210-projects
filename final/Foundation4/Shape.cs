public class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return 0;
    }

    public virtual double GetPerimeter()
    {
        return 0;
    }

    public void Display()
    {
        Console.WriteLine($"Shape: {GetType().Name}");
        Console.WriteLine($"Color: {_color}");
        Console.WriteLine($"Area: {GetArea()}");
        Console.WriteLine($"Perimeter: {GetPerimeter()}");
    }
}