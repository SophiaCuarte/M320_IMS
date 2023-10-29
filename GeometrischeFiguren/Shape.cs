﻿namespace GeometrischeFiguren
{
    using System;

    public class Shape
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Shape(float x, float y)
        {
            X = x;
            Y = y;
        }

        public virtual void PrintPosition()
        {
            Console.WriteLine($"Position (linke obere Ecke): [{X}, {Y}]");
        }

        public virtual void PrintArea()
        {
            Console.WriteLine("Fläche: nicht definiert");
        }
    }
}
