//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).


using System;
using System.Globalization;
using System.Threading;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Radius of circle :");
            double radius = double.Parse((Console.ReadLine()));

            Console.Write("What is the X-coordinate of your point: ");
            double xCoord = double.Parse(Console.ReadLine());

            Console.Write("What is the Y-coordiante of your point: ");
            double yCoord = double.Parse(Console.ReadLine());

            bool pointInside = (Math.Pow(xCoord,2) + Math.Pow(yCoord,2) <= Math.Pow(radius,2));

            if (pointInside)
            {
                Console.WriteLine("The point IS inside the circle.");
            }
            else
            {
                Console.WriteLine("The point is NOT inside the circle.");
            }
            Console.WriteLine();


        }
    }
}
