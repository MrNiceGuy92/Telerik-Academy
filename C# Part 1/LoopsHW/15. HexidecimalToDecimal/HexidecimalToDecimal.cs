//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class HexidecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Hexidecimal number: ");
            string hex = Console.ReadLine().ToUpper();


            long result = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case 'A': result += 10* (long)Math.Pow(16, hex.Length - i - 1); ; break;
                    case 'B': ; result += 11 * (long)Math.Pow(16, hex.Length - i - 1); ; break;
                    case 'C': ; result += 12 * (long)Math.Pow(16, hex.Length - i - 1); ; break;
                    case 'D': ; result += 13 * (long)Math.Pow(16, hex.Length - i - 1); ; break;
                    case 'E': ; result += 14 * (long)Math.Pow(16, hex.Length - i - 1); ; break;
                    case 'F': ; result += 15 * (long)Math.Pow(16, hex.Length - i - 1); ; break;
                    default: result += (hex[i] - '0') * (long)Math.Pow(16, hex.Length - i - 1);
                        break;
                }

            }
            Console.WriteLine();
            Console.Write("Decimal representation: ");
            Console.WriteLine(result);
        }
    }
