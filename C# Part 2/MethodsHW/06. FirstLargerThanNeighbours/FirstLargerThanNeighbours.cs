//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, 
//if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Length of array: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Input array:");
        int[] numArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("numArray[{0}]= ", i);
            numArray[i] = int.Parse(Console.ReadLine());
        }

        if (length == 1)
        {
            Console.WriteLine("Only one element, hence {0} is largest.", numArray[0]);
            return;
        }

        Console.WriteLine(); // Remember index of arrays start from 0
        Console.Write("Index of first element, larger than neighbours: ");
        Console.WriteLine(CheckNeighbours(numArray));
    }

    static int CheckNeighbours(int[] elements)
    {
        int position = 0;
        bool isBigger = false;

        for (int i = 1; i < elements.Length - 1; i++)
        {
            bool check = elements[i] > elements[i+1] && elements[i] > elements[i-1];
            if (check)
            {
                position = i;
                isBigger = true;
                break;
            }
            else if (!check && elements[0] > elements[1])
            {
                position = 0;
                isBigger = true;
                break;
            }
            else if (!check && elements[elements.Length - 1] > elements[elements.Length - 2])
            {
                position = elements.Length - 1;
                isBigger = true;
                break;
            }
           
        }
        if (isBigger)
        {
            return position;
        }
        else
        {
            return -1;
        }
    }
}

