using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Shapes Project.");

        // Square square = new Square("red", 2);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        // Rectangle r = new Rectangle(4, 2, "black");
        // Console.WriteLine(r.GetColor());
        // Console.WriteLine(r.GetArea());

        // Circle c = new Circle(4, "blue");
        // Console.WriteLine(c.GetColor());
        // Console.WriteLine(c.GetArea());

        List<Shape> shapes= new List<Shape>();
        Square s = new Square("red", 2);
        shapes.Add(s);

        Rectangle r = new Rectangle(4, 2, "black");
        shapes.Add(r);

        Circle c = new Circle(4, "blue");
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}