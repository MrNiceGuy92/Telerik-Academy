//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Numerics;

namespace FactorialOverFactorial
{
    class FactorialOverFactorial
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

            bool check = (1 < chosenN) && (chosenN < 100) && (chosenK < chosenN);

            if (check)
            {
                for (int i = chosenN, j =chosenK; i > 1; i--, j--)
                {
                    firstFactorial *= i;
                    if (j>1)
                    {
                        secondFactorial *= j; 
                    }
                    fraction = firstFactorial / secondFactorial;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.WriteLine();
            Console.WriteLine("Answer: {0}", fraction);
        }
    }
}
