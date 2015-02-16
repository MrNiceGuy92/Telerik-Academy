//Problem 1. Odd or Even Integers
//
//Write an expression that checks if given integer is odd or even.


using System;

namespace OddOrEvevn
{
    class OddOrEvevn
    {
        static void Main()
        {
            Console.Write("Write a number N:");
            int number = Int32.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number " + number + " is EVEN.");
            }
            else
            {
                Console.WriteLine("The number " + number + " is ODD.");
            }
            
        }
    }
}
