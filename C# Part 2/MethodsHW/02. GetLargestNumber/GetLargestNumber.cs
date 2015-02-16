//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GetLargestNumber
{
    //Of course if, like in exam, int is very big, we can use BigInteger or long.

    static void Main()
    {
        Console.WriteLine("Enter three numbers");
        Console.WriteLine();
        Console.Write("First number: ");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Second number: ");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Third number: ");
        int third = int.Parse(Console.ReadLine());

        Console.WriteLine();
        if (third > GetMax(first, second))
        {
            Console.WriteLine("Biggest number: {0}", third);

        }
        else if (third == GetMax(first, second))
        {
            Console.WriteLine("Biggest number: {0}", third);
        }
        else if (third < GetMax(first, second))
        {
            Console.WriteLine("Biggest number: {0}", GetMax(first, second));
        }
    }

    static int GetMax(int firstNum, int secondNum)
    {
        int result;
        result = Math.Max(firstNum, secondNum);

        return result;
    }
}

