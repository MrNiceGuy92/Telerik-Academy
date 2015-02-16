//Problem 18.* Trailing Zeroes in N!

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


    class TrailingZerosInFactorial
    {
        static void Main()
        {
            Console.Write("Choose integer: ");
            int someInt = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= someInt; i++)
            {
                factorial *= i;
            }

            string ournum = factorial.ToString();

            int counter = 0;

            int[] numArray = new int[ournum.Length];

            for (int i = 0; i < ournum.Length; i++)
            {
                numArray[i] = int.Parse(ournum[i].ToString());
            }

            for (int i = 1; i <= numArray.Length; i++)
            {
                if (numArray[numArray.Length - i] == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }

