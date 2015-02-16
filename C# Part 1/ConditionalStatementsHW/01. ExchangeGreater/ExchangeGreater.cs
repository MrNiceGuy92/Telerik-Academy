//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if 
//the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;

namespace ExchangeGreater
{
    class ExchangeGreater
    {
        static void Main()
        {
            Console.WriteLine("Compare the numbers of your choice:");
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            double placeholderNum = 0;

            if (firstNum>secondNum)
            {
                placeholderNum = firstNum;
                firstNum = secondNum;
                secondNum = placeholderNum;
                Console.WriteLine("Result: {0}" + " " + "{1}", firstNum, secondNum);
            }
            else
            {
                Console.WriteLine("Result: {0}" + " " + "{1}", firstNum, secondNum);
            }
        }
    }
}
