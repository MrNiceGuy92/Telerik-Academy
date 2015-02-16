//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseTheNumber
{
    static void Main()
    {
        Console.Write("Input decimal number: "); //The number is decimal, ie you can input 12.5 for example
        decimal someDecimal = decimal.Parse(Console.ReadLine());

        char[] charArray = someDecimal.ToString().ToCharArray();

        Console.WriteLine();
        Console.Write("The decimal number reversed: ");
        Console.WriteLine(ReverseNumber(charArray));

    }
    static char[] ReverseNumber(char[] someArray)
    {
        Array.Reverse(someArray);
        return someArray;
    }
}
