namespace GeometrischeFiguren
{
    using System;

    public class Rectangle : Shape, IRotatable
    {
        private float _length1 = 100;
        private float _length2 = 50;

        public Rectangle(float length1, float length2, float x = 100f, float y = 100f) : base(x, y)
        {
            if (length1 > 0)
            {
                _length1 = length1;
            }

            if (length2 > 0)
            {
                _length2 = length2;
            }
        }

        public float Length1
        {
            get => _length1;
            set
            {
                _length1 = value > 0 ? value : 0;
            }
        }

        public float Length2
        {
            get => _length2;
            set
            {
                _length2 = value > 0 ? value : 0;
            }
        }

        public new void PrintPosition()
        {
            Console.WriteLine($"Top left corner is at X={X}, Y={Y}");
            Console.WriteLine($"Bottom right corner is at X={X + Length1}, Y={Y + Length2}");
        }

        public void Rotate()
        {
            Console.WriteLine("Rectangle: Rotate 90 degrees clockwise using an alternative method.");
        }

        public override void PrintArea()
        {
            var area = Length1 * Length2;
            Console.WriteLine($"The rectangle's area is {area}.");
        }
    }
}
