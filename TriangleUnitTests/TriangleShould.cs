using System;
using Xunit;

namespace TriangleUnitTests
{
    public class TriangleShould
    {
        [Fact]
        public void ReturnTriangleIfParametersIsCorrect()
        {
            var triangle = new Triangle.Triangle(4, 5, 2);

            Assert.NotNull(triangle);

            Assert.Equal(4, triangle.SideA);
            Assert.Equal(5, triangle.SideB);
            Assert.Equal(2, triangle.SideC);
        }
        
        [Fact]
        public void ThrowArgumentExceptionIfTriangleDoesNotExist()
        {
            Assert.Throws<ArgumentException>(() => new Triangle.Triangle(1, 2, 3));
        }

        [Fact]
        public void ThrowArgumentExceptionIfOneSideOfTriangleIsZero()
        {
            Assert.Throws<ArgumentException>(() => new Triangle.Triangle(0, 2, 3));
            Assert.Throws<ArgumentException>(() => new Triangle.Triangle(1, 0, 3));
            Assert.Throws<ArgumentException>(() => new Triangle.Triangle(1, 2, 0));
        }
    }
}
