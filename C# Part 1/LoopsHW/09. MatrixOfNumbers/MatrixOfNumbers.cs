//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number n (1 = n = 20) 
//and prints a matrix like in the examples below. Use two nested loops.

using System;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Choose an integer: ");
            int chosenInt = int.Parse(Console.ReadLine());

            for (int row = 1; row <= chosenInt; row++)
            {
                for (int i = row; i <= chosenInt + row - 1; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }
    }
}
