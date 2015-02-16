//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 < n < 100).

using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Choose Nth Catalan number: ");
            int nthCatalan = int.Parse(Console.ReadLine());

            bool check = (0 <= nthCatalan) && (nthCatalan < 100);

            BigInteger firstFactorial = 1;
            BigInteger secondFactorial = 1;
            BigInteger thirdFactorial = 1;
            BigInteger catalan = 0;


            if (check)
            {
                for (int i = 1; i <= 2*nthCatalan; i++)
                {
                    firstFactorial *= i;
                }
                for (int i = 1; i <= nthCatalan + 1; i++)
                {
                    secondFactorial *= i;
                }
                for (int i = 1; i <= nthCatalan; i++)
                {
                    thirdFactorial *= i;
                }

                catalan = firstFactorial / (secondFactorial * thirdFactorial);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine();
            Console.WriteLine("Result: {0}", catalan);

        }
    }
}
