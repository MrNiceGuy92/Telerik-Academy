//Problem 14. Quick sort

//Write a program that sorts an array of integers using the Quick sort algorithm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class QuickSort
{
    static void Main(string[] args)
    {
        //Hardcoded example
        string input = "4, 3, 1, 4, 2, 5, 8";

        int[] numbers = input
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n)).ToArray();

        // Sort the array
        Quicksort(numbers, 0, numbers.Length - 1);

        // Print the sorted array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Quicksort(int[] numbers, int left, int right)
    {
        int i = left, j = right;
        int pivot = numbers[(left + right) / 2];

        while (i <= j)
        {
            while (numbers[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (numbers[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                Swap(numbers, i, j);

                i++;
                j--;
            }
        }

        // Recursive calls
        if (left < j)
        {
            Quicksort(numbers, left, j);
        }

        if (i < right)
        {
            Quicksort(numbers, i, right);
        }
    }

    //swaping elements
    private static void Swap(int[] numbers, int i, int j)
    {
        int temp;
        temp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = temp;
    }
}
