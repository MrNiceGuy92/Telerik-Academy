//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

namespace RandomNumbersInRange
{
    class RandomNumbersInRange
    {
        static void Main()
        {
            Console.Write("Enter number of integers: ");
            int numOfInt = int.Parse(Console.ReadLine());

            Console.Write("Min range: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Max range: ");
            int max = int.Parse(Console.ReadLine());

            Random generator = new Random();

            Console.WriteLine();

            Console.Write("Random numbers in range: ");

            for (int i = 1; i <= numOfInt; i++)
            {
                Console.Write(generator.Next(min, max + 1) + " ");
            }
            Console.WriteLine();
        }
    }
}
