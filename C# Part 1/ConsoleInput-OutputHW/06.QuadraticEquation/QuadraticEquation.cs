//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation 
//ax2 + bx + c = 0 and solves it (prints its real roots).



using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Coefficient A: ");
            double coeffA = double.Parse(Console.ReadLine());

            Console.Write("Coefficient B: ");
            double coeffB = double.Parse(Console.ReadLine());

            Console.Write("Coefficient C: ");
            double coeffC = double.Parse(Console.ReadLine());

            double discriminant = Math.Pow(coeffB, 2) - (4 * coeffA * coeffC);

            double rootOne = (-coeffB + Math.Sqrt(discriminant)) / (2 * coeffA);
            double rootTwo = (-coeffB - Math.Sqrt(discriminant)) / (2 * coeffA);
            
            Console.WriteLine();
            if (discriminant < 0)
            {
                Console.WriteLine("No real roots.");
            }
            if (discriminant == 0)
            {
                Console.WriteLine("One real root: {0}", rootOne);
            }
            if (discriminant > 0)
            {
                Console.WriteLine("The roots of the quadratic equation are: {0} and {1}", rootOne, rootTwo);
            }

        }
    }
}
