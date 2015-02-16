//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.


using System;
using System.Globalization;
using System.Threading;

namespace AreaOfTrapezoid
{
    class AreaOfTrapezoid
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Side A of trapezoid: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Side B of trapezoid :");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Height of trapezoid: ");
            double height = double.Parse(Console.ReadLine());

            double area = ((sideA + sideB)/2) * height;

            Console.WriteLine("The area of the trapezoid is: {0}", area);

        }
    }
}
