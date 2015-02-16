//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindSumInArray
{
    static void Main()
    {
        //Hardcoded example from problem
        string input = "4, 3, 1, 4, 2, 5, 8";
        int findSum = 11; 

        int[] numbers = input
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n)).ToArray();

        //Input everything by hand
        //Console.Write("Input elements of array, separated by comma: ");
        //string input = Console.ReadLine();

        //int[] numbers = input
        //    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
        //    .Select(n => int.Parse(n)).ToArray();
        //Console.Write("Enter sum S: ");
        //int findSum = int.Parse(Console.ReadLine()); 
        
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int someSum = numbers[i];
            for (int j = i + 1; j < numbers.Length; j++)
            {
                someSum += numbers[j];
                if (someSum == findSum)
                {
                    Console.Write("The sequence is: ");
                    for (int index = i; index <= j; index++) //Elements in sequence will be between i and j
                    {
                        if (index < j)
                        {
                            Console.Write(numbers[index] + ",");
                        }
                        else
                        {
                            Console.Write(numbers[index]);
                        }
                    }
                    Console.WriteLine();
                    return;
                }
                else if (someSum > findSum)
                {
                    someSum = 0;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

