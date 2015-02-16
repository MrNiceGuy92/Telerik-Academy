//Problem 8. Numbers from 1 to n

//Write a program that reads an integer number n from the console and prints 
//all the numbers in the interval [1..n], each on a single line.


using System;

namespace PrintOneToN
{
    class PrintOneToN
    {
        static void Main(string[] args)
        {
            Console.Write("Your integer number: ");
            int someNum = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= someNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
