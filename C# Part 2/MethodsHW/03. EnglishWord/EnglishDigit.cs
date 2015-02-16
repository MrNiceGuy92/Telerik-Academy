//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Of course if, like in exam, int is very big, we can use BigInteger or long.

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Choose an integer: ");
        int chosenInt = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
        Console.WriteLine(GetLastDigit(chosenInt));
    }

    static string GetLastDigit(int someNumber)
    {
        string digit;

        int result;
        result = someNumber % 10;

        switch (result)
        {
            case 1: digit = "One"; break;
            case 2: digit = "Two"; break;
            case 3: digit = "Three"; break;
            case 4: digit = "Four"; break;
            case 5: digit = "Five"; break;
            case 6: digit = "Six"; break;
            case 7: digit = "Seven"; break;
            case 8: digit = "Eight"; break;
            case 9: digit = "Nine"; break;
            default: digit = "Zero"; break;
        }
        return digit;
    }
}

