using System;
using System.Collections.Generic;
using System.Drawing;

namespace GeometrischeFiguren
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> shapes = new List<Figure>();

            shapes.Add(new Circle(5));
            shapes.Add(new Rectangle(6, 4));
            shapes.Add(new Square(3));

            foreach (Figure shape in shapes)
            {
                shape.PrintPosition();
                shape.PrintArea();

                if (shape is IRotatable)
                {
                    IRotatable rotatable = (IRotatable)shape;
                    rotatable.Rotate();
                }

                Console.WriteLine();
            }
        }
    }
}
