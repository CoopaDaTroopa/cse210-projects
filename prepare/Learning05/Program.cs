using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Rectangle("Orange", 9, 9.6));
        shapes.Add(new Square("Pink", 4.3));
        shapes.Add(new Square("Yellow", 12.9));
        shapes.Add(new Circle("Blue", 3.1));
        shapes.Add(new Circle("The Blood of my Enemies", 6.9));
        shapes.Add(new Rectangle("Magenta", 5, 10.1));
        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine($"{s.GetArea()}");
        }
    }
}