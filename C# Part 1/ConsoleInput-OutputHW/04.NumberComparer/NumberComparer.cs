//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.


using System;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            double biggerNum = Math.Max(firstNum, secondNum);

            Console.WriteLine("Bigger number of two: {0}",biggerNum);
        }
    }
}
