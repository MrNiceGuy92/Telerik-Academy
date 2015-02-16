//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Choose a number: ");
            long input = long.Parse(Console.ReadLine());

            long remainder = 0;
            long intPart;
            long temp;
            string result = "";

                do
                {
                    intPart = input / 2;
                    remainder = input % 2;
                    result += remainder;
                    temp = intPart;
                    input = temp;

                } while (intPart > 0);

                Console.WriteLine();

                Console.Write("Binary representation: ");
                for (int i = 0; i < result.Length ; i++)
                {
                    Console.Write(result[result.Length - i - 1]);
                }
                Console.WriteLine();
            
        }
    }

