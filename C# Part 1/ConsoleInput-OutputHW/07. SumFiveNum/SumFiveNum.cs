//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), 
//calculates and prints their sum.


using System;

namespace SumFiveNum
{
    class SumFiveNum
    {
        static void Main(string[] args)
        {
            Console.Write("Write five numbers, separated by space: ");
            string numbers = Console.ReadLine();

            double sum = 0;

            string[] arrayOfNum = numbers.Split( new char []{' '}, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < arrayOfNum.Length; i++)
            {
                sum += double.Parse(arrayOfNum[i]);
            }

            Console.WriteLine();
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
