using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Red", 4);
        shapes.Add(square);
        Circle circle = new Circle("Blue", 3);
        shapes.Add(circle);
        Rectangle rectangle = new Rectangle("Green", 2, 5);
        shapes.Add(rectangle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}