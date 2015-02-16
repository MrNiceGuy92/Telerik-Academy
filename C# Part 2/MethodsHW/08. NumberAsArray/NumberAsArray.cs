//Problem 8. Number as array

//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class NumberAsArray
{
    static void Main()
    {
        //Hardcoded tests:
        //int[] test = { 1, 2, 3 };
        //int[] secTest = { 4, 5, 6 };

        //User input of arrays
        //The arrays are of type int, since their lengths are < 10 000
        Console.Write("Length of first array: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Input array:");
        int[] firstArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("numArray[{0}]= ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.Write("Length of second array: ");
        int secondLength = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Input array:");
        int[] secondArray = new int[secondLength];
        for (int i = 0; i < secondLength; i++)
        {
            Console.Write("numArray[{0}]= ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        //

        Console.WriteLine();
        Console.WriteLine(new string('-', 30));
        Console.Write("Sum of numbers: ");
        Console.WriteLine(AdditionOfNums(firstArray, secondArray));
    }

    static BigInteger AdditionOfNums(int[] firstArray, int[] secondArray)
    {
        // We need to reverse the array, since in the problem it is stated that 
        //the last digit is kept in arr[0]).

        Array.Reverse(firstArray);
        Array.Reverse(secondArray);

        string firstStrOfArray = String.Join("", firstArray);
        string secondStrOfArray = String.Join("", secondArray);

        //We use BigInteger since the sum could be huge 
        BigInteger firstNum = BigInteger.Parse(firstStrOfArray);
        BigInteger secondNum = BigInteger.Parse(secondStrOfArray);

        Console.Write("{0} + {1} = ", firstNum, secondNum);
        return firstNum + secondNum;
    }
}
