//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToBinaryTransform
{
    static void Main()
    {
        //Easy way (Comment out rest of code if using easy way)

        //Console.Write("Input number: ");
        //int input = int.Parse(Console.ReadLine());
        //string result = Convert.ToString(input, 2);
        //Console.Write("Result: ");
        //Console.WriteLine(result);

        //Alternative way

        Console.Write("Input decimal number: ");
        long input = long.Parse(Console.ReadLine());
        Console.Write("Binary number: ");
        Console.WriteLine(DecimalToBinary(input));
    }

    static char[] DecimalToBinary(long number)
    {
        string result = "";

        long remainder = 0;

        while (number > 0)
        {
            remainder = number % 2;
            result += remainder;
            number = number / 2;
        }

        char[] someArray = result.ToCharArray();

        Array.Reverse(someArray);

        return someArray;
    }
}

