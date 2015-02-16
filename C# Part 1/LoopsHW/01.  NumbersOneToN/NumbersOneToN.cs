//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n and prints all
//the numbers from 1 to n, on a single line, separated by a space.

using System;

namespace NumbersOneToN
{
    class NumbersOneToN
    {
        static void Main()
        {
            Console.Write("Choose a number: ");
            int yourNum = int.Parse(Console.ReadLine());

            int num = 1;

            while (num < yourNum)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
    }
}
