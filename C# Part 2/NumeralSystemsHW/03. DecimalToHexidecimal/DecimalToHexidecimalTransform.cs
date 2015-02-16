//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToHexidecimalTransform
{
    static void Main()
    {
        //Easy way (Comment out rest of code if using easy way)

        //Console.Write("Input decimal number: ");
        //int decNumber = int.Parse(Console.ReadLine());
        //string hexValue = decNumber.ToString("X");
        //Console.Write("Hexidecimal value: ");
        //Console.WriteLine(hexValue);

        //Alternative way

        Console.Write("Input decimal number: ");
        long decNumber = long.Parse(Console.ReadLine());
        Console.Write("Hexidecimal value: ");
        Console.WriteLine(DecimalToHex(decNumber));
    }

    static char[] DecimalToHex(long number)
    {
        string result = "";
        long remainder = 0;

        while (number > 0)
        {
            remainder = number % 16;
            if (remainder >= 0 && remainder <=9)
            {
                result += remainder;
            }
            else
            {
                switch (remainder)
                {
                    case 10: result += "A"; break;
                    case 11: result += "B"; break;
                    case 12: result += "C"; break;
                    case 13: result += "D"; break;
                    case 14: result += "E"; break;
                    case 15: result += "F"; break;
                }
            }
            number /= 16;
        }

        char[] someArray = result.ToCharArray();

        Array.Reverse(someArray);

        return someArray;
    }
}
