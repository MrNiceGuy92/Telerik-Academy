﻿//Problem 8. Binary short

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter a number of type short: ");
        short number = short.Parse(Console.ReadLine());

        Console.WriteLine("\n{0} to binary short representtation: {1}\n", number, ConvertToBinary(number));
    }

    static string ConvertToBinary(int number)
    {
        string binary = string.Empty;
        for (int i = 15; i >= 0; i--)
        {
            binary = ((number % 2) & 1) + binary;
            number >>= 1;

            if (i % 4 == 0) binary = " " + binary;
        }
        return binary;
    }
}


