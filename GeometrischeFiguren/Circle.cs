namespace GeometrischeFiguren
{
    using System;

    public class Circle : Figure
    {
        public float Radius { get; set; }

        public Circle(float radius, float x = 100f, float y = 100f) : base(x, y)
        {
            if (radius > 0)
                Radius = radius;
            else
                Radius = 1.0f;
        }

        public override void PrintPosition()
        {
            Console.WriteLine($"Mittelpunkt: [{X + Radius}, {Y + Radius}]");
        }

        public override void PrintArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"Fläche des Kreises: {area}");
        }
    }
}