//Problem 1. Allocate array

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AllocateArray
{
    static void Main()
    {
        //Allocating Array
        int[] intArray = new int[20];

        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = 5 * i;
        }

        //Printing
        foreach (int num in intArray)
        {
            Console.WriteLine(num);
        }

        //Alternative Printing
        //Console.WriteLine(string.Join(",", intArray));
    }
}

