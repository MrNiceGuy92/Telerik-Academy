//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Length of first array: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Length of second array: ");
        int M = int.Parse(Console.ReadLine());

        int[] firstArray = new int[N];
        int[] secondArray = new int[M];

        int counter = 0;

        Console.WriteLine(new string('-', 20));
        if (M == N)
        {
            //Reading array elements from console
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("FirstArray[{0}]: ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine();

            for (int i = 0; i < firstArray.Length; i++) 
            {
                Console.Write("SecondArray[{0}]: ", i);
                secondArray[i] = int.Parse(Console.ReadLine());

            }
            //Checking equality
            for (int i = 0; i < firstArray.Length; i++) //It is also right to use secondArray.Length, since they are the same
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++; //If all elements are equal, the counter would be equal to the lenght of the array (ie counter = M = N)
                }
            }

            Console.WriteLine(new string('-', 20));

            if (counter == M)   //Reminder: M = N 
            {
                Console.WriteLine("The arrays are the same.");
            }
            else
            {
                Console.WriteLine("The arrays are different!");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The arrays are different!");
        }
    }
}
        // ALTERNATIVE SOLUTION (Evlogi)

        //Console.Write("Length of first array: ");
        //int N = int.Parse(Console.ReadLine());

        //Console.Write("Length of second array: ");
        //int M = int.Parse(Console.ReadLine());

        //int[] firstArray = new int[N];
        //int[] secondArray = new int[M];

        //bool areEqual = true;

        //if (M != N)
        //{
        //    areEqual = false;
        //}
        //else
        //{
        //    for (int i = 0; i < M; i++)
        //    {
        //        if ( firstArray[i] != secondArray[i])
        //        {
        //            areEqual = false;
        //        }
        //    }
        //}
        //if (areEqual)
        //    {
        //         Console.WriteLine("The arrays are equal.");
        //    }
        //else
        //    {
        //        Console.WriteLine("The arrays are NOT equal.");



//// Alternative solution 2: using .Net's functionality - Does NOT show the 1 by 1 comparison, still does it though.
//bool areArraysEqual = firstArray.SequenceEqual(secondArray);

//if (areArraysEqual)
//{
//    Console.WriteLine("The two arrays are equal!");
//}
//else
//{
//    Console.WriteLine("The two arrays are NOT equal (takes into account positioning)");
//}