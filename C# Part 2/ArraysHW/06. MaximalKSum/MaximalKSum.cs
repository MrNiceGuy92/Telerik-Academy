//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The maximal K sum will be the sum of the largest K numbers in the array

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter value N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter value K: ");
        int K = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Enter elements in array:");

        string[] numStr = new string[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("numStr[{0}]= ", i);
            numStr[i] = Console.ReadLine();
        }
        int[] numArray = numStr.Select(int.Parse).ToArray();

        Array.Sort(numArray);
        Array.Reverse(numArray);

        int maximalSum = 0;
        string kNums = " ";
   
        for (int i = 0; i < K; i++)
        {
            maximalSum += numArray[i];
            if (i < K - 1)
            {
                kNums += numArray[i] + ",";
            }
            else
            {
                kNums += numArray[i];
            }
            
        }
        Console.WriteLine();
        Console.WriteLine("Maximal Sum of K elements: {0}", maximalSum);
        Console.WriteLine("Th K elements: {0}", kNums);
        
    }
}

