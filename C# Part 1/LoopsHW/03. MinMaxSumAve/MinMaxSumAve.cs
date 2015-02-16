//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;
using System.Linq;

namespace MinMaxSumAve
{
    class MinMaxSumAve
    {
        static void Main()
        {
            Console.Write("Choose the number of values you want to compare: ");
            int chosenInt = int.Parse(Console.ReadLine());

            int[] numbers = new int[chosenInt];

            for (int i = 0; i < numbers.Length ; i++)
            {
                Console.Write("Number {0} :", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int min = numbers.Min();
            int max = numbers.Max();
            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            //double average = numbers.Average();
            //int sum = numbers.Sum();

            double average = (double)sum / chosenInt;

            Console.WriteLine();
            Console.WriteLine("Min: {0}\nMax:{1}\nSum:{2}\nAve: {3:F2}", min, max, sum, average);

            
            
        }
    }
}
