//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length 
//of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Input elements of array, separated by comma: ");
        string input = Console.ReadLine(); 

        string[] stringArray = input
            .Split(new char[] { ',', '\t',' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => n).ToArray();

        for (int i = 0; i < stringArray.Length; i++)
        {
            for (int j = 0; j < stringArray.Length; j++)
            {
                if (stringArray[i].Length < stringArray[j].Length)
                {
                    Swap(stringArray, i, j);
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Sorted array by length of string:");
        foreach (string item in stringArray)
        {
            Console.WriteLine(item);
        }
    }

    static void Swap(string[] stringArray, int first, int second)
    {
        string temp = "";
        temp = stringArray[first];
        stringArray[first] = stringArray[second];
        stringArray[second] = temp;
    }
}

//Alternative solution with LINQ

//string[] sortedArray = stringArray
//    .OrderBy(x => x.Length)
//    .ToArray();

//Console.WriteLine("Sorted array by length of string:");
//foreach (string element in sortedArray)
//{
//    Console.WriteLine(element);
//}