//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexidecimalToDecimalTransform
{
    static void Main()
    {
        //Easy way (Comment out rest of code if using easy way)

        //Console.Write("Input hexidecimal number: ");
        //string input = Console.ReadLine();
        //Console.Write("Decimal number: ");
        //int decimalNumber = int.Parse(input, System.Globalization.NumberStyles.HexNumber);
        //Console.WriteLine(decimalNumber);

        //Alternative way

        Console.Write("Input hexidecimal number: ");
        string input = Console.ReadLine(); ;

        Console.Write("Decimal number: ");
        Console.WriteLine(HexidecimalToDecimal(input));
    }

    static long HexidecimalToDecimal(string input)
    {
        char[] inputArray = input.ToCharArray(); //string is char array by default, ie you can skip the conversion to input.Array 
        long result = 0;
        int position = 0;

        for (int i = inputArray.Length - 1; i >= 0; i--)
        {
            if (inputArray[i] >= '0' && inputArray[i] <='9')
            {
                result += (inputArray[i] - '0') * (long)Math.Pow(16, position);
                position++;
            }
            else
            {
                switch (inputArray[i])
                {
                    case 'A': result += 10 * (long)Math.Pow(16, position); position++; break;
                    case 'B': result += 11 * (long)Math.Pow(16, position); position++; break;
                    case 'C': result += 12 * (long)Math.Pow(16, position); position++; break;
                    case 'D': result += 13 * (long)Math.Pow(16, position); position++; break;
                    case 'E': result += 14 * (long)Math.Pow(16, position); position++; break;
                    case 'F': result += 15 * (long)Math.Pow(16, position); position++; break;
                }
            }
            
        }
        return result;
    }
}

