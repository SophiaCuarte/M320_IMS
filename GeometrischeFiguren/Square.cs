namespace GeometrischeFiguren
{
    using System;

    public class Square : Rectangle, IRotatable
    {
        public Square(float sideLength) : base(sideLength, sideLength)
        {
        }

        public void Rotate()
        {
            Console.WriteLine("Ein Quadrat kann nicht rotiert werden.");
        }
    }
}