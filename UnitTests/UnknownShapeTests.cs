using System;
using CalculateArea;
using CalculateArea.Shapes;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class UnknownShapeTests
    {
        [Fact]
        public void CalculateArea_ThrowNotImplementedException_WhenUnknownShape()
        {
            var sides = new double[]{1, 2, 3, 4, 5};
            var unknownShape = new UnknownShape(sides);
            
            Action act = () => unknownShape.CalculateArea();
            
            act.Should()
                .Throw<NotImplementedException>()
                .WithMessage(ExceptionShapeHelper.UnknownShapeCalculateAreaMessage);
        }
    }
}