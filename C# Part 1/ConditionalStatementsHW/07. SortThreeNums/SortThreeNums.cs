//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

using System;

namespace SortThreeNums
{
    class SortThreeNums
    {
        static void Main()
        {
            Console.WriteLine("Pick numbers:");
            Console.WriteLine();

            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            Console.Write("Third number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (firstNum >= secondNum && firstNum >= thirdNum) 
            {
                if (secondNum >= thirdNum)
                {
                    Console.WriteLine("Descending order: {0},{1},{2}", firstNum, secondNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("Descending order: {0},{1},{2}", firstNum, thirdNum, secondNum);
                }
            }
            else if (secondNum > firstNum && secondNum > thirdNum)
            {
                if (firstNum > thirdNum)
                {
                    Console.WriteLine("Descending order: {0},{1},{2}", secondNum, firstNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("Descending order: {0},{1},{2}", secondNum, thirdNum, firstNum);
                }
            }
            else if (thirdNum > secondNum && thirdNum > firstNum)
            {
                if (secondNum > firstNum)
                {
                    Console.WriteLine("Descending order: {0},{1},{2}", thirdNum, secondNum, firstNum);
                }
                else
                {
                    Console.WriteLine("Descending order: {0},{1},{2}", thirdNum, firstNum, secondNum);
                }
            }
            Console.WriteLine();
        }
    }
}
