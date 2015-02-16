//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToDecimalTransform
{
    static void Main()
    {
        //Easy way (Comment out rest of code if using easy way)

        //Console.Write("Input binary number: ");
        //string input = Console.ReadLine();
        //int decimalNumber = Convert.ToInt32(input, 2);
        //Console.Write("Decimal numbber: ");
        //Console.WriteLine(decimalNumber);

        //Alternative way

        Console.Write("Input BINARY number: ");
        string input = Console.ReadLine();
        Console.Write("Decimal number: ");
        Console.WriteLine(BinaryToDecimal(input));
    }

    static long BinaryToDecimal(string input)
    {
        int[] binNums = input.Select(x => x - '0').ToArray(); 
        long result = 0;
        int position = 0;
        for (int i = binNums.Length - 1; i >= 0; i--)
        {
            result += binNums[i] * (long)Math.Pow(2, position);
            position++;
        }

        return result;
    }
}

