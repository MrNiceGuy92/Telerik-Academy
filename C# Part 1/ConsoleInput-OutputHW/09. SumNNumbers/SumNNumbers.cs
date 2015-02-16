//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and 
//calculates and prints their sum. Note: You may need to use a for-loop.


using System;

namespace SumNNumbers
{
    class SumNNumbers
    {
        static void Main()
        {
            Console.Write("How many numbers would you like to sum: ");
            int numsToSum = Int32.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= numsToSum; i++)
            {   
                Console.Write("Write {0} number: ",i);
                double num = double.Parse(Console.ReadLine());
                sum += num; 
            }
            Console.WriteLine();
            Console.WriteLine("Total sum of numbers: {0}",sum);
        }
    }
}
