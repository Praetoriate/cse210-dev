using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("red", 5);
        Rectangle rec1 = new Rectangle("green", 3, 8);
        Circle circle1 = new Circle("blue", 4);

        shapes.Add(square1);
        shapes.Add(rec1);
        shapes.Add(circle1);

        foreach (Shape shp in shapes)
        {
            Console.WriteLine($"The {shp.GetColour()} shape has an area of {shp.GetArea()} units.");
        }

    }
}