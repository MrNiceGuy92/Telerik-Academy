//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
namespace OddEvenProduct
{
    class OddEvenProduct
    {
        static void Main()
        {
            Console.Write("Write your numbers, separated by space: ");
            string[] numbers = Console.ReadLine().Split();

            int[] intArray = new int [numbers.Length];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(numbers[i]);
            }

            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 1; i < intArray.Length; i= i + 2)
            {
                evenProduct *= intArray[i];
            }

            for (int i = 0; i < intArray.Length; i = i + 2)
            {
                oddProduct *= intArray[i];
            }

            Console.WriteLine();

            if (evenProduct == oddProduct)
            {
                Console.WriteLine("The products are EQUAL.");
            }
            else
            {
                Console.WriteLine("The products are NOT equal.");
            }
        }
    }
}
