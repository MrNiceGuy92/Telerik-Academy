//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;

namespace BiggestOfThreeNum
{
    class BiggestOfThreeNum
    {
        static void Main()
        {
            Console.WriteLine("Choose numbers to compare:");
            Console.WriteLine();
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine().Trim());

            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine().Trim());

            Console.Write("Third number: ");
            double thirdNum = double.Parse(Console.ReadLine().Trim());

            Console.WriteLine();

            double maxNum = firstNum;

            if (secondNum > maxNum)
            {
                maxNum = secondNum;
            }
            if (thirdNum > maxNum)
            {
                maxNum = thirdNum;
            }
               
            Console.WriteLine("The biggest number is {0}.", maxNum);
   
        }
    }
}

