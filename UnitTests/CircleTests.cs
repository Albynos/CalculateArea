using System;
using CalculateArea;
using CalculateArea.Shapes;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(10d, 314d)]
        [InlineData(5d,78.5d)]
        public void CalculateArea_WithCorrectRadius(double radius, double expectedArea)
        {
            var circle = new Circle(radius);

            var result = circle.CalculateArea();
            
            result.Should().Be(expectedArea);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void ThrowArgumentException_WhenZeroOrNegativeRadius(double radius)
        {
            Action act = () => new Circle(radius);
            
            act.Should()
                .Throw<ArgumentException>()
                .WithMessage(ExceptionShapeHelper.NegativeOrZeroValueMessage);
        }
    }
}