//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalIncreasingSequence
{
    static int i;

    static void Main()
    {
        //Hardcoded example from problem
        string input = "3, 2, 3, 4, 2, 2, 4";

        int[] numbers = input
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n)).ToArray();

        //Input everything by hand
        //Console.Write("Input elements of array, separated by comma: ");
        //string input = Console.ReadLine();

        //int[] numbers = input
        //    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
        //    .Select(n => int.Parse(n)).ToArray();
        //Console.WriteLine();

        int counter = 1;
        int bestStart = 0;
        int bestLen = 0;

        for (i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                counter++;
            }
            else if (counter >= bestLen)
            {
                bestLen = counter;
                bestStart = i - bestLen + 1;
                counter = 1;
            }
            else
            {
                counter = 1;
            }
        }

        if (counter >= bestLen)
        {
            bestLen = counter;
            bestStart = i - bestLen + 1;
            counter = 1;
        }

        //Printing
        Console.Write("Max incresing sequence: ");
        for (int j = bestStart; j < bestStart + bestLen; j++)
        {
            if (j < bestStart + bestLen - 1)
            {
                Console.Write(numbers[j] + ",");
            }
            else
            {
                Console.Write(numbers[j]);
            }
        }
        Console.WriteLine();
    }
}



