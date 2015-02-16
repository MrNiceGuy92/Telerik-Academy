//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NFactorial
{
    static void Main()
    {
        Console.Write("Input n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        while (n < 1 || n > 100)
        {
            Console.WriteLine("n must be between 1 and 100.");
            Console.Write("Input n: ");
            n = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0}! = ", i);
            Console.WriteLine(Factorial(i));
        }
    }

    static int Factorial(int n)
    {
        int[] numArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            numArray[i] = i;
        }

        int productOfArray = 1;

        for (int i = 1; i < n; i++)
        {
            productOfArray *= i;
        }

        return n * productOfArray;
    }
}

