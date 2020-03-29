using System;
using Triangle;
using Xunit;

namespace TriangleUnitTests
{
    public class TriangleTypeCalculatorShould
    {
        private readonly TriangleTypeCalculator _triangleTypeCalculator = new TriangleTypeCalculator();

        [Fact]
        public void ThrowArgumentNullExceptionIfTriangleIsNullWhenCalculate()
        {
            Assert.Throws<ArgumentNullException>(() => _triangleTypeCalculator.Calculate(null));
        }
        
        [Fact]
        public void ReturnRightTriangleWhenCalculate()
        {
            var triangle = new Triangle.Triangle(3, 4, 5);

            var result = _triangleTypeCalculator.Calculate(triangle);

            Assert.Equal(TriangleTypes.RightTriangle, result);
        }

        [Fact]
        public void ReturnObtuseTriangleWhenCalculate()
        {
            var triangle = new Triangle.Triangle(4, 4, 6);

            var result = _triangleTypeCalculator.Calculate(triangle);

            Assert.Equal(TriangleTypes.ObtuseTriangle, result);
        }

        [Fact]
        public void ReturnAcuteTriangleWhenCalculate()
        {
            var triangle = new Triangle.Triangle(4, 4, 5);

            var result = _triangleTypeCalculator.Calculate(triangle);

            Assert.Equal(TriangleTypes.AcuteTriangle, result);
        }
    }
}
