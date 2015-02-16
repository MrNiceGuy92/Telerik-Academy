//Problem 7. One system to any other

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Input number: ");
        string number = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Choose a base S: ");
        int baseS = int.Parse(Console.ReadLine());
        while (baseS < 2)
        {
            Console.WriteLine("Base must be bigge than 2!");
            Console.Write("baseS:");
            baseS = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        Console.Write("Choose a base D: ");
        int baseD = int.Parse(Console.ReadLine());
        while (baseD < 2 || baseD > 16)
        {
            Console.WriteLine("Base must be bigge than 2 and less than 16!");
            Console.Write("baseD:");
            baseD = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        long numberInS = SystemToDecimal(number, baseS);
        Console.WriteLine("Number in base D: ");
        Console.WriteLine(DecimalToSystem(numberInS, baseD));
    }

    static long SystemToDecimal(string input, int numeralSystemS)
    {
        long decimalNumber = 0;

        for (int i = 0; i < input.Length; i++)
        {
            int digit = 0;
            if (input[i] >= '0' && input[i] <= '9')
            {
                digit = input[i] - '0';
            }
            else
            {
                digit = input[i] - 'A' + 10; 
            }
            decimalNumber += digit * (long)Math.Pow(numeralSystemS, input.Length - i - 1);
        }
        return decimalNumber;
    }

    static string DecimalToSystem(long decimalNumber, int numeralSystemD)
    {
        string result = "";

        while (decimalNumber > 0)
        {
            long digit = decimalNumber / numeralSystemD;
            if (digit >= 0 && digit <= 9)
            {
                result = (char)(digit + '0') + result;
            }
            else
            {
                result = (char)(digit + 'A' - 10) + result;
            }
            decimalNumber /= numeralSystemD;
        }
        return result;
    }
}

