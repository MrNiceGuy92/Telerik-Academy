//Problem 6. binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToHexidecimalTransformDURVARSKI
{
    static void Main()
    {
        //Napulno durvarski nachin

        Console.Write("Enter binary number: ");
        string input = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Hexidecimal number: ");
        Console.WriteLine(HexToBinary(input));
    }

    static string HexToBinary(string input)
    {
        int lenght = input.Length;
        int paddingZeros = (lenght % 4);
        switch (paddingZeros)
        {
            case 1: paddingZeros = 3; break;
            case 2: paddingZeros = 2; break;
            case 3: paddingZeros = 1; break;
            default: paddingZeros = 0; break;
        }

        input = input.PadLeft(lenght + paddingZeros, '0');
        
        string result = "";
       
        for (int i = 0; i < input.Length; i+=4)
        {
            string hexValue = "";
            for (int j = i; j < 4 + i; j++)
            {
                hexValue += input[j];
            }

            switch (hexValue)
            {
                case "0000": result += "0"; break;
                case "0001": result += "1"; break;
                case "0010": result += "2"; break;
                case "0011": result += "3"; break;
                case "0100": result += "4"; break;
                case "0101": result += "5"; break;
                case "0110": result += "6"; break;
                case "0111": result += "7"; break;
                case "1000": result += "8"; break;
                case "1001": result += "9"; break;
                case "1010": result += "A"; break;
                case "1011": result += "B"; break;
                case "1100": result += "C"; break;
                case "1101": result += "D"; break;
                case "1110": result += "E"; break;
                case "1111": result += "F"; break;
            }
        }
        return result;
    }
}

