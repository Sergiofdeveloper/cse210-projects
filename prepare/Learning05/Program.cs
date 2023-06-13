using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Shape> formas = new List<Shape>();
        Square square = new Square ("Red", 5);
        formas.Add(square);

        Rectangle rectangle = new Rectangle("Green", 3, 4);
        formas.Add(rectangle);

        Circle circle = new Circle("Blue", 2.5);
        formas.Add(circle);
        foreach (Shape forma in formas)
        {
            string color = forma.Color;
            double area = forma.GetArea();

            Console.WriteLine($"Square color: {color}");
            Console.WriteLine ($"Square area: {area}");

        }
        Console.ReadLine();
    }
}