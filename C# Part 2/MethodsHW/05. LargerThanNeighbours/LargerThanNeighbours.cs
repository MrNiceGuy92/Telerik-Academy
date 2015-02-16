//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array 
//of integers is larger than its two neighbours (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargerThanNeighbours
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

        Console.WriteLine();
        Console.Write("Enter position to check: "); //Remember index of arrays start from zero
        int chosenPosition = int.Parse(Console.ReadLine());

        while (chosenPosition < 0 || chosenPosition >= length)
        {
            Console.WriteLine("Wrong position! Please try again.");
            chosenPosition = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("Is number bigger than neighbours?: ");
        Console.WriteLine(CheckNeighbours(chosenPosition, numArray));
    }

    static bool CheckNeighbours(int position, int[] elements)
    {
        bool isBigger = false;

        for (int index = position; index < elements.Length; index++)
        {
            if (position == 0)
            {
                isBigger = elements[position] > elements[position + 1];
            }
            else if (position == elements.Length - 1)
            {
                isBigger = elements[position] > elements[position - 1];
            }
            else if ( position != elements.Length - 1 && elements[position] > elements[position+1] 
                && elements[position] > elements[position - 1])
            {
                isBigger = true;
            }
        }
        return isBigger;
    }
}

