using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapeList = new List<Shape>();
        double radius = 2;
        string color = "yellow";
        Circle circle = new Circle(color, radius);
        double length = 4;
        double width = 3;
        Square square = new Square(color, length);
        Rectangle rectangle = new Rectangle(color, length, width);
        shapeList.Add(circle);
        shapeList.Add(rectangle);
        shapeList.Add(square);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
        

    }
}