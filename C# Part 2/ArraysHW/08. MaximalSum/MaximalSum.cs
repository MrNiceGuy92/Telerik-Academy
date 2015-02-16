//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main()
    {
        int[] numbersArray = { 2, -3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int startPoint = 0;
        int endPoint = 0;
        int maxSum = 0;
        int currentSum = 0;


        for (int i = 0; i < numbersArray.Length; i++)
        {
            currentSum += numbersArray[i];
            if (currentSum > maxSum)
            {
                endPoint = i;
                maxSum = currentSum;
            }
            else if (currentSum < 0)
            {
                startPoint = i + 1;
                currentSum = 0;
            }
        }

        //printing sequence

        Console.Write("The max sum is: {0}\r\nThe numbers in this sequence are: ", maxSum);
        for (int i = startPoint; i <= endPoint; i++)
        {
            Console.Write("{0} ", numbersArray[i]);
        }
    }
}

