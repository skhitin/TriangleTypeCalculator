using System;
using System.Linq;

namespace Triangle
{
    public class TriangleTypeCalculator : ITriangleTypeCalculator
    {
        public TriangleTypes Calculate(Triangle triangle)
        {
            if (triangle == null)
            {
                throw new ArgumentNullException(nameof(triangle));
            }

            var sides = new byte[] { triangle.SideA, triangle.SideB, triangle.SideC };
            sides = sides.OrderByDescending(x => x).ToArray();

            var sideC2 = sides[0] * sides[0];
            var summSideA2PlusSideB2 = sides[1] * sides[1] + sides[2] * sides[2];

            if (sideC2 == summSideA2PlusSideB2)
            {
                return TriangleTypes.RightTriangle;
            }
            else
            {
                if (sideC2 > summSideA2PlusSideB2)
                {
                    return TriangleTypes.ObtuseTriangle;
                }
                else
                {
                    return TriangleTypes.AcuteTriangle;
                }
            }
        }
    }
}
