//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// I NEED A SWITCH CASE FOR A, B, C etc.  help :)

class DecimalToHex
{
    static void Main()
    {
        Console.Write("Write a decimal number: ");
        long chosenNum = long.Parse(Console.ReadLine());

        string result = "";

        long intPart;
        long remainder;
        long temp;

       
            do
            {
                intPart = chosenNum / 16;
                remainder = chosenNum % 16;
                result += remainder;
                temp = intPart;
                chosenNum = temp;

            }
            while (intPart > 0); 
       
        

        Console.WriteLine();
        Console.Write("Hexidecimal representation: ");

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[result.Length - i - 1]);
        }
        Console.WriteLine();
        
    }
}

