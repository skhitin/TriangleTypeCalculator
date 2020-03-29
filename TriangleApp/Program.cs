using System;
using Triangle;

namespace TriangleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowTriangleTypeWithSides(5, 4, 3);
            ShowTriangleTypeWithSides(4, 4, 3);
            ShowTriangleTypeWithSides(4, 4, 7);

            Console.ReadLine();
        }

        private static void ShowTriangleTypeWithSides(byte sideA, byte sideB, byte sideC)
        {
            var triangle = new Triangle.Triangle(sideA, sideB, sideC);

            var triangleTypeCalculator = new TriangleTypeCalculator();

            var triangleType = triangleTypeCalculator.Calculate(triangle);

            Console.WriteLine($"The triangle with sides: A={triangle.SideA}, B={triangle.SideB} and C={triangle.SideC} is {triangleType}\n");
        }
    }
}
