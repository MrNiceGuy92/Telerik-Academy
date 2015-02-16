//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Collections.Generic;

namespace RandomizeNumbers
{
    class RandomizeNumbers
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int chosenInt = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Random order: ");

            List<int> numbers = new List<int>();
            int initialCounter = 1;

            while (initialCounter <= chosenInt)
	            {
                    Random randomNum = new Random();
                    int newNum = randomNum.Next(1, chosenInt + 1);

                    if (!numbers.Contains(newNum))
                    {
                        numbers.Add(newNum);
                        initialCounter++;
                    }
                }

            Console.Write(String.Join(",",numbers));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
