//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, there 
//are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

namespace Combinatorics
{
    class Combinatorics
    {
        static void Main()
        {
            Console.Write("Choose an integer N: ");
            int chosenN = int.Parse(Console.ReadLine());

            Console.Write("Choose an integer K: ");
            int chosenK = int.Parse(Console.ReadLine());

            BigInteger fraction = 0;
            BigInteger firstFactorial = 1;
            BigInteger secondFactorial = 1;
            BigInteger thirdFactorial = 1;

            bool check = (1 < chosenN) && (chosenN < 100) && (chosenK < chosenN);

            if (check)
            {
                for (int i = chosenN, j = chosenK; i > 1; i--, j--)
                {
                    firstFactorial *= i;
                    if (j > 1)
                    {
                        secondFactorial *= j;
                    }
                }
                for (int i = 1; i <= chosenN - chosenK; i++)
			        {
                        thirdFactorial *= i;
			        }
                fraction = firstFactorial / (secondFactorial * thirdFactorial);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine();
            Console.WriteLine("Result: {0}", fraction);
        }
    }
}
