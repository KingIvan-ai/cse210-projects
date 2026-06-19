class Program
{
    static void Main(string[] args)
    {
        // Build a list of shapes
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 4));
        shapes.Add(new Rectangle("blue", 5, 3));
        shapes.Add(new Circle("green", 7));

        // Iterate and display each shape's color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()},  Area: {shape.GetArea()}");
        }
    }
}
