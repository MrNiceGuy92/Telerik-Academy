//Problem 15.* Number calculations

//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class NumberCalculations
{
    static void Main()
    {
        //User input array
        Console.Write("Length of array: ");
        long length = long.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Input array:");
        long[] chosenArray = new long[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("numArray[{0}]= ", i);
            chosenArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        Console.Write("Maximum: ");
        Console.WriteLine(Maximum(chosenArray));
        Console.WriteLine();

        Console.Write("Minimum: ");
        Console.WriteLine(Minimum(chosenArray));
        Console.WriteLine();

        Console.Write("Average: ");
        Console.WriteLine(Average(chosenArray));
        Console.WriteLine();

        Console.Write("Sum: ");
        Console.WriteLine(Sum(ref chosenArray));
        Console.WriteLine();

        Console.Write("Product: ");
        Console.WriteLine(Product(chosenArray));
        Console.WriteLine();
    }

    static long Sum<long[]>(ref long[] someArray)
    {
        long sum = 0;
        foreach (long num in someArray)
        {
            sum += num;
        }
        return sum;
    }

    static BigInteger Product(params long[] someArray)
    {
        BigInteger product = 1;
        foreach (long num in someArray)
        {
            product *= num;
        }
        return product;
    }

    static decimal Average(params long[] someArray)
    {
        long sum = 0;
        decimal average = 0;
        foreach (long num in someArray)
        {
            sum += num;
        }
        average = sum / someArray.Length;
        return average;
    }

    static long Minimum(params long[] someArray)
    {
        long min = someArray.Min();
        return min;
    }

    static long Maximum(params long[] someArray)
    {
        long max = someArray.Max();
        return max;
    }
}

