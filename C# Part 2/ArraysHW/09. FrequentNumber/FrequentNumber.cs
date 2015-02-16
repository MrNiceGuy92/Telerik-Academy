//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FrequentNumber
{
    static void Main()
    {
        ////Hardcoded example from problem
        //string input = "4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3";

        //int[] numbers = input
        //    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
        //    .Select(n => int.Parse(n)).ToArray();

        //User input of array
        Console.WriteLine("Input elements of array, separated by comma: ");
        string input = Console.ReadLine();
        int[] numbers = input
            .Split(new char[] { ',', ' ','\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n)).ToArray();

        int maxCount = 0;
        int currentPosition = numbers[0];
        int frequentNumber = 0;
        int currentCount = 0;

        Array.Sort(numbers); //Sorting numbers to later get maximal sequence of equal elements
                             //Similar logic as Problem 4
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != currentPosition)
            {
                currentCount = 1;
                currentPosition = numbers[i];
            }
            else
            {
                currentCount++;
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                frequentNumber = currentPosition;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Most frequent number: {0}", frequentNumber);
        Console.WriteLine("Number of times number appears: {0}", maxCount);
    }
}

