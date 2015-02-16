//Problem 13. Solve tasks

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Tasks:\n");
        Console.WriteLine("1 => Reverse the digits of a number.");
        Console.WriteLine("2 => Calculate the average of a sequence of integers.");
        Console.WriteLine("3 => Solve a linear equation a * x + b = 0");
        Console.WriteLine(new string('-',20));
        Console.Write("Choose a task: ");
        int task = int.Parse(Console.ReadLine());
        Console.WriteLine();

        while (task < 1 || task > 3)
        {
            Console.WriteLine("Incorrect input!");
            Console.Write("Input a number [1,3]:");
            task = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        if (task == 1)
        {
            Console.WriteLine("Input non-negative decimal number:");
            decimal decimalNumber = decimal.Parse(Console.ReadLine());
            while (decimalNumber < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Decimal number must be positive!");
                Console.Write("Input positive number: ");
                decimalNumber = decimal.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Reversed number: ");
            Console.WriteLine(ReverseNumber(decimalNumber));
        }
        else if (task == 2)
        {
            Console.Write("Input sequence of intgers, separated by comma: ");
            string sequence = Console.ReadLine();
            int[] numbers = sequence.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n)).ToArray();
            Console.WriteLine();
            while(numbers.Length <= 0)
            {
                Console.WriteLine("The sequence cannot be empty!");
                Console.Write("Input sequence of intgers, separated by comma: ");
                sequence = Console.ReadLine();
                numbers = sequence.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n)).ToArray();
            }

            Console.Write("Averge of numbers: ");
            Console.WriteLine(FindAverage(numbers));
        }
        else
        {
            Console.WriteLine("Input coefficients of linear equation:");
            Console.Write("Coefficient A: ");
            decimal coeffA = decimal.Parse(Console.ReadLine()); //Coefficients could be decimal numbers
            while (coeffA == 0)
	        {
	            Console.WriteLine("Coefficient A must not be zero!");
                Console.Write("Coefficient A: ");
                coeffA = decimal.Parse(Console.ReadLine());
	        }
            Console.Write("Coefficient B: ");
            decimal coeffB = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Solution of linear equation: ");
            Console.WriteLine("x = {0}", SolveLinearEquation(coeffA, coeffB));
        }
    }

    static char[] ReverseNumber(decimal decimalNumber)
    {
        char[] charArray = decimalNumber.ToString().ToCharArray();

        Array.Reverse(charArray);

        return charArray;
    }

    static decimal FindAverage(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        decimal average;
        average = (decimal)sum / numbers.Length;

        return average;
    }

    static decimal SolveLinearEquation(decimal coeffA, decimal coeffB)
    {
        decimal solution;

        if ((coeffA > 0 && coeffB > 0) || (coeffA < 0 && coeffB < 0))
        {
            solution = (decimal)coeffB / coeffA;
            return -solution;
        }
        else if((coeffA > 0 && coeffB < 0) || (coeffA < 0 && coeffB > 0))
	    {
            solution = (decimal)coeffB / (-coeffA);
            return solution;
        }
        return -1;
    }
}