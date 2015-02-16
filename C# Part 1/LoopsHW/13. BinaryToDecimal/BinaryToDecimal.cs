//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
using System.Linq;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Write your binary number: ");
            string binNum = Console.ReadLine();

            long number = 0;

            for (int i = 0; i < binNum.Length; i++)
            {
                if (binNum[i] == '1')
                {
                    number += (long)Math.Pow(2, binNum.Length - i - 1);
                }

            }
            Console.WriteLine(number);

        }
    }
}
