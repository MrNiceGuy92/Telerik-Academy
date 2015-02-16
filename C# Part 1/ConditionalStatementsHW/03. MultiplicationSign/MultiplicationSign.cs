//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("To find the sign of the product of three numbers, type them in:");
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
            {
                Console.WriteLine("The result is ZERO.");
            }
            else if (firstNum > 0)
            {
                if (secondNum > 0 && thirdNum > 0)
                {
                    Console.WriteLine("The sign is +.");
                }
                if (secondNum > 0 && thirdNum < 0)
                {
                    Console.WriteLine("The sign is -.");
                }
                if (secondNum < 0 && thirdNum > 0)
                {
                    Console.WriteLine("The sign is -.");
                }
                if (secondNum < 0 && thirdNum < 0)
                {
                    Console.WriteLine("The sign is +.");
                }
            }
            else if (firstNum < 0)
            {
                if (secondNum > 0 && thirdNum > 0)
                {
                    Console.WriteLine("The sign is -.");
                }
                if (secondNum > 0 && thirdNum < 0)
                {
                    Console.WriteLine("The sign is +.");
                }
                if (secondNum < 0 && thirdNum > 0)
                {
                    Console.WriteLine("The sign is +.");
                }
                if (secondNum < 0 && thirdNum < 0)
                {
                    Console.WriteLine("The sign is -.");
                }
            }
        }
    }
}
