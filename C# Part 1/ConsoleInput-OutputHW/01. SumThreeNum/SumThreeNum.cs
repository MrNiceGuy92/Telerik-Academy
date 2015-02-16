//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.


using System;

namespace SumThreeNum
{
    class SumThreeNum
    {
        static void Main()
        {
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            Console.Write("Third number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            double sum = firstNum + secondNum + thirdNum;

            Console.WriteLine("The sum of the three numbers is: {0}", sum);
        }
    }
}
