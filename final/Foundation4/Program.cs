using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Triangle("Green", 3, 4, 3, 4, 5));

        foreach (Shape s in shapes)
        {
            s.Display();
            Console.WriteLine();
        }
    }
}