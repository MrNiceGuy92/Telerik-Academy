//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SelectionSort
{
    static void Main()
    {
        //Hardcoded example
        //string input = "2, 3, 16, 1, 2, 1, 6, 4, 8, 8";

        //User input
        Console.Write("Enter elements of array, separated by comma: ");
        string input = Console.ReadLine();

        int[] numbers = input
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n)).ToArray();


        for (int i = 0; i < numbers.Length - 1; i++)   
        {
            for (int j = i + 1; j < numbers.Length; j++)    
            {
                int temp = 0;
                if (numbers[i] > numbers[j])  
                {
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        Console.Write("Sorted array: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[numbers.Length - 1])
            {
                Console.Write(numbers[i] + ",");
            }
            else
            {
                Console.Write(numbers[i]);
            }
        }
        Console.WriteLine();
    }
}

//Alternative solution (Evlogi)
//static void Main()
//    {
//        int[] arr = { 5, 1, 2, 6, 8, 3, 4 };

//        int minValue;
//        int minIndex = -1;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            minValue = int.MaxValue;
//            for (int j = i + 1; j < arr.Length; j++)
//            {
//                if (minValue > arr[j])
//                {
//                    minValue = arr[j];
//                    minIndex = j;
//                }
//            }

//            int temp = arr[i];
//            arr[i] = minValue;
//            arr[minIndex] = temp;
//        }

//        Console.WriteLine(string.Join(", ", arr));
//    }