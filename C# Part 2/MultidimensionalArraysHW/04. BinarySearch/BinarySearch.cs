//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Input elements of array, separated by comma: ");
        string input = Console.ReadLine();

        int[] numArray = input
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n)).ToArray();

        Console.Write("Input integer K: ");
        int K = int.Parse(Console.ReadLine());

        Array.Sort(numArray); //Array needs to be sorted before applying Array.BinarySearch();

        int index = int.MinValue;
        for (int i = 0; i <= K; i++)
		{
            int num = K - i;
		    index = Array.BinarySearch(numArray, num);
            if (index >= 0)
            {
                break;
            }
            else
            {
                continue;
            }
		}
        Console.WriteLine(); //Reminder: Index of arrays start from 0
        Console.Write("Index of largest number in array <= K: ");
        Console.WriteLine(index);
    }
}

