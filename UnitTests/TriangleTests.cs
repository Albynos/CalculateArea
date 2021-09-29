using System;
using CalculateArea;
using CalculateArea.Shapes;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(5,6,7,14.7)]
        public void CalculateArea_ByThreeSides(double a, double b, double c, double expectedArea)
        {
            var triangle = new Triangle(a,b,c);
            
            var result = triangle.CalculateArea();
            
            triangle.IsRight.Should().BeFalse();
            result.Should().Be(expectedArea);
        }

        [Theory]
        [InlineData(3,4,5,6)]
        public void CalculateArea_WhenRightTriangle(double a, double b, double c,double expectedArea)
        {
            var triangle = new Triangle(a, b, c);
            
            var result = triangle.CalculateArea();
            
            triangle.IsRight.Should().BeTrue();
            result.Should().Be(expectedArea);
        }

        [Theory]
        [InlineData(0,1,2)]
        [InlineData(3,4,-5)]
        public void IsCorrectTriangle_ThrowArgumentException_WhenZeroOrNegativeSides(
            double a, double b, double c)
        {
            Action act = () => new Triangle(a, b, c);
            
            act.Should()
                .Throw<ArgumentException>()
                .WithMessage(ExceptionShapeHelper.NegativeOrZeroValueMessage);
        }

        [Theory]
        [InlineData(3,4,7)]
        public void IsCorrectTriangle_ThrowArgumentException_WhenTriangleCantCreateWithSides(
            double a, double b, double c)
        {
            Action act = () => new Triangle(a, b, c);
            
            act.Should()
                .Throw<ArgumentException>()
                .WithMessage(ExceptionShapeHelper.TriangleWithWrongSidesMessage);
        }
    }
}