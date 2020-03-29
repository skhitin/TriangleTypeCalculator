using System;
using System.Linq;

namespace Triangle
{
    public class Triangle
    {
        public byte SideA { get; }
        public byte SideB { get; }
        public byte SideC { get; }

        public Triangle(byte sideA, byte sideB, byte sideC)
        {
            TrowExceptionIfSideIsZero(sideA, nameof(sideA));
            TrowExceptionIfSideIsZero(sideB, nameof(sideB));
            TrowExceptionIfSideIsZero(sideC, nameof(sideC));

            var sides = new byte[] { sideA, sideB, sideC }
            .OrderByDescending(x => x).ToArray();

            if (!IsTriangle(sides))
                throw new ArgumentException($"Triangle with sides: A={sideA}, B={sideB} and C={sideC} does not exist");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        private bool IsTriangle(byte[] sides)
        {
            return sides[0] < sides[1] + sides[2];
        }

        private void TrowExceptionIfSideIsZero(byte side, string sideName)
        {
            if (side == 0)
                throw new ArgumentException($"{sideName} is 0, must more 0");

        }
    }
}
