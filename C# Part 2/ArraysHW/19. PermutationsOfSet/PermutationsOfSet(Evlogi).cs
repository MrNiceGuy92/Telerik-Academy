//Problem 19.* Permutations of set

//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PermutationsOfSet
{
    static void Main()
    {
        int n = 3; //Console.ReadLine();

        //Fill up array
        int[] someArray = new int[n];
        for (int i = 0; i < someArray.Length; i++)
        {
            someArray[i] = i + 1;
        }

        Permutation(someArray, 0);
    }

    private static void Permutation(int[] someArray, int index)
    {
        //Bottom of recursion
        if (index == someArray.Length)
        {
            Console.WriteLine(string.Join(", ", someArray));
            return;
        }

        //Update of recursion
        for (int i = index; i < someArray.Length; i++)
        {
            Swap(someArray, i, index);
            Permutation(someArray, index + 1);
            Swap(someArray, i, index);
        }
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

}

