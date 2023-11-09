using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();


        Square s1 = new Square(4, "yellow");
        shapes.Add(s1);

        Rectangle s2 = new Rectangle(4, 12, "blue");
        shapes.Add(s2);

        Circle s3 = new Circle(6, "red");
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double areas = s.GetArea();
            Console.WriteLine($"{color}, {areas:F2}");
        }
        //
        //Console.WriteLine($"{square.GetColor()}, {square.GetArea()}");

        //
        //Console.WriteLine($"{rectangle.GetColor()}, {rectangle.GetArea()}");

        //
        //Console.WriteLine($"{circle.GetColor()}, {circle.GetArea():F2}");

    }
}