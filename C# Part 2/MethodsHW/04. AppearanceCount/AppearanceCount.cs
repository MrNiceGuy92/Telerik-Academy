//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AppearanceCount
{
    static void Main()
    {
        //Test with these or input own data below
        //int[] someArray = {1,2,3,3,3,3,3,12};
        //int chosenInt = 3;

        //User input of array
        Console.Write("Choose a number: ");
        int chosenInt = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Length of array: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Input array:");
        int[] someArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("numArray[{0}]= ", i);
            someArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.Write("Number of times your chosen number appears in array: ");
        Console.WriteLine(InputArray(chosenInt, someArray));
    }

    static int InputArray(int chosenNum, int[] elements)
    {
        int counter = 0;
        for (int i = 0; i < elements.Length; i++)
        {        
            if (elements[i] == chosenNum)
            {
                counter++;
            }
        }
        return counter;
    }
}

