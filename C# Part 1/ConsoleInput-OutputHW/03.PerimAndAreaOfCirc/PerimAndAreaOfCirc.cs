//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area 
//formatted with 2 digits after the decimal point.



using System;
namespace PerimAndAreaOfCirc
{
    class PerimAndAreaOfCirc
    {
        static void Main()
        {
            Console.Write("What is the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter = Math.Round(2 * Math.PI * radius, 2);
            double area = Math.Round(Math.PI * radius * radius, 2);
            Console.WriteLine();

            Console.WriteLine("Perimeter of circle: {0:F2}", perimeter);
            Console.WriteLine("Area of circle: {0:F2}", area);
        }
    }
}
