using System;

namespace CalculateArea.Shapes
{
    public class UnknownShape : BaseShape
    {
        public UnknownShape(double[] sides) : base(sides) { }

        public override double CalculateArea()
        {
            //Если будет конкретное ТЗ то реализую этот метод
            throw new NotImplementedException(ExceptionShapeHelper.UnknownShapeCalculateAreaMessage);
        }
    }
}