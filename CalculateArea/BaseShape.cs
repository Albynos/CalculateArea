using System;
using System.Linq;

namespace CalculateArea
{
    public abstract class BaseShape : IShape
    {
        protected readonly double[] Sides;

        protected BaseShape(double[] sides)
        {
            Sides = sides;
            if (Sides.Any(side => side <= 0))
                throw new ArgumentException(ExceptionShapeHelper.NegativeOrZeroValueMessage);
        }

        public abstract double CalculateArea();
    }
}