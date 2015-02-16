//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;
namespace SumOfFractions
{
    class SumOfFractions
    {
        static void Main()
        {
            Console.Write("Chosse an integer N: ");
            int chosenN = int.Parse(Console.ReadLine());

            Console.Write("Choose an integer X: ");
            int chosenX = int.Parse(Console.ReadLine());

            double sum = 1;
            double factorial = 1;

            for (int i = 1, j = 1; i <= chosenN; i++, j++)
            {
                factorial *= i; 
                sum += factorial / Math.Pow(chosenX, j);
            }

            Console.WriteLine();
            Console.WriteLine("The sum is {0:F5}", sum);
        }
    }
}
