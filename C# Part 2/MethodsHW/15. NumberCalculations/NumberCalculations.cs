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

//Alternative solution
//enum Operation
//        {
//            opSum,
//            opAverage,
//            opMax,
//            opMin,
//            opProduct
//        }

//        static int OperateInteger(Operation op, params int[] values)
//        {
//            int min = values[0];
//            int max = values[0];
//            int sum = values[0];
//            int product = values[0];

//            for (int i = 1; i < values.Length; i++)
//            {
//                if (values[i] > max)
//                {
//                    max = values[i];
//                }

//                if (values[i] < min)
//                {
//                    min = values[i];
//                }

//                sum += values[i];
//                product *= values[i];
//            }

//            switch (op)
//            {
//                case Operation.opMin:
//                    return min;
//                case Operation.opMax:
//                    return max;
//                case Operation.opAverage:
//                    return sum / values.Length;
//                case Operation.opSum:
//                    return sum;
//                case Operation.opProduct:
//                    return product;
//                default:
//                    return (int)0;
//            }
//        }

//        static void Main()
//        {
//            Console.WriteLine("Enter number of elements: ");
//            int m = int.Parse(Console.ReadLine());
//            int[] values = new int[m];

//            for (int i = 0; i < m; i++)
//            {
//                Console.WriteLine("Enter number {0}: ", i + 1);
//                values[i] = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("Sum: " + OperateInteger(Operation.opSum, values));
//            Console.WriteLine("Min: " + OperateInteger(Operation.opMin, values));
//            Console.WriteLine("Max: " + OperateInteger(Operation.opMax, values));
//            Console.WriteLine("Average: " + OperateInteger(Operation.opAverage, values));
//            Console.WriteLine("Product: " + OperateInteger(Operation.opProduct, values));
//        }