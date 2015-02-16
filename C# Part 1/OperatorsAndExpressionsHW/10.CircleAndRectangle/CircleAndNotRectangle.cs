//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the 
//circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).


using System;
using System.Globalization;
using System.Threading;

namespace CircleAndNotRectangle
{
    class CircleAndNotRectangle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Circle radius and center
            double radius = 1.5;
            int xCenterOfCircle = 1;
            int yCenterOfCircle = 1;

            Console.Write("What is the X-coordinate of your point: ");
            double xCoord = double.Parse(Console.ReadLine());

            Console.Write("What is the Y-coordiante of your point: ");
            double yCoord = double.Parse(Console.ReadLine());

            bool pointInsideCircle = Math.Pow((xCenterOfCircle-xCoord),2) + Math.Pow((yCenterOfCircle-yCoord),2) 
                <= Math.Pow(radius,2);
            
            bool pointInsideRect = (-1<=xCoord) && (xCoord<=5) && (-1<=yCoord) && (yCoord<=1);


            if (pointInsideCircle && !pointInsideRect)
            {
                Console.WriteLine("YES, the point is inside the circle, but outside the rectangle.");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
