//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    static void Main()
    {
        //Input everything by hand
        Console.Write("Input elements of array, separated by comma: ");
        string input = Console.ReadLine();

        int[] numbers = input
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n)).ToArray();

        Console.Write("Input element whose index you want to find: ");
        int searchNum = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //Hardcoded example
        //string input = "4, 3, 1, 4, 2, 5, 8";
        //int searchNum = 8; //Take any element in array
        //int[] numbers = input
        //    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
        //    .Select(n => int.Parse(n)).ToArray();

        Array.Sort(numbers); //Sorting array so we can apply binary search

        int max = numbers.Length;
        int min = 0;
        int position = (max - min) / 2; //Midpoint

        for (int i = min; i < max; i++)
		{
            if(searchNum < numbers[position])
            {
                position = position - 1;
            }
            else if (searchNum > numbers[position])
            {
                position = position + 1;
            }
            else
            {
                break;
            }
		} //Reminder: Index of arrays start from 0
        Console.WriteLine("The number {0} has index {1} in array.", searchNum, position);
    }
}
