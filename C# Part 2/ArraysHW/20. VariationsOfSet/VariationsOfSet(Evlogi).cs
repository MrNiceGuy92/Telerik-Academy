//Problem 20.* Variations of set

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VariationsOfSetEvlogi
{
    static void Main()
    {
        int n = 3; //int.Parse(Console.ReadLine());
        int k = 2; //int.Parse(Console.ReadLine());

        int[] someArray = new int[n];
        
        //Filling up elements in array
        for (int i = 0; i < n; i++)
        {
            someArray[i] = i + 1;
        }

        Variations(someArray, new int[k], 0);
    }

    private static void Variations(int[] numbers, int[] someArray, int index)
    {
        //Bottom of recursion
        if (index == someArray.Length)
        {
            Console.WriteLine(string.Join(", ", someArray));
            return;
        }

        //Update
        for (int i = 0; i < numbers.Length; i++)
        {
            someArray[index] = numbers[i];
            Variations(numbers, someArray, index + 1);
        }
    }
}

