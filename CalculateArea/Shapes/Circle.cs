using System;

namespace CalculateArea.Shapes
{
    public class Circle : BaseShape
    {
        private readonly double _r;
        private const double pi = 3.14d;

        public Circle(double r) : base(new []{r})
        {
            _r = r;
        }

        public override double CalculateArea() => Math.Round(pi * _r * _r, 2);
    }
}