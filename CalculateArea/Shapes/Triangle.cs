using System;

namespace CalculateArea.Shapes
{
    public class Triangle : BaseShape
    {
        public readonly bool IsRight;
        
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        
        public Triangle(double a, double b, double c) : base(new []{a,b,c})
        {
            Array.Sort(Sides);
            _a = Sides[0];
            _b = Sides[1];
            _c = Sides[2];
            
            if (!IsCorrectTriangle())
                return;
            
            IsRight = _c * _c == _a * _a + _b * _b;
        }

        public override double CalculateArea()
        {
            var s = IsRight 
                ? CalculateAreaBySideAndHeight()
                : CalculateAreaByThreeSides();
            return Math.Round(s,2);
        }

        private double CalculateAreaBySideAndHeight() => 0.5d * _a * _b;

        private double CalculateAreaByThreeSides()
        {
            var semiPerimeter = (_a + _b + _c) / 2d;
            var area = Math.Sqrt(semiPerimeter * (semiPerimeter - _a) * (semiPerimeter - _b) * (semiPerimeter - _c));
            return area;
        }
        private bool IsCorrectTriangle()
        {
            if (_a + _b <= _c || _a + _c <= _b || _b + _c <= _a)
            {
                throw new ArgumentException(ExceptionShapeHelper.TriangleWithWrongSidesMessage);
            }

            return true;
        }
    }
}