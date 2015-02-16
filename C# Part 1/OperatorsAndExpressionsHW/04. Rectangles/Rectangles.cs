//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.


using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.Write("Height of rectangle: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Width of rectangle: ");
            double width = double.Parse(Console.ReadLine());

            double areaOfRect = height * width;
            double parameterOfRect = (2 * height) + (2 * width);

            Console.Write("Area of Rectangle: {0}",areaOfRect);
            Console.WriteLine("");
            Console.Write("Parameter of Rectangle: {0}",parameterOfRect);
            Console.WriteLine("");
        }
    }
}
