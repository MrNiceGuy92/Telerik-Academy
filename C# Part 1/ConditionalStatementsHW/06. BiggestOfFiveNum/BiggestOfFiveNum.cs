//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

namespace BiggestOfFiveNum
{
    class BiggestOfFiveNum
    {
        static void Main()
        {
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine().Trim());

            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine().Trim());

            Console.Write("Third number: ");
            double thirdNum = double.Parse(Console.ReadLine().Trim());

            Console.Write("Fourth number: ");
            double fourthNum = double.Parse(Console.ReadLine().Trim());

            Console.Write("Fifth number: ");
            double fifthNum = double.Parse(Console.ReadLine().Trim());


            double maxValue = firstNum;

            if (secondNum > maxValue)
            {
                maxValue = secondNum;
            }

            if (thirdNum > maxValue)
            {
                maxValue = thirdNum;
            }

            if (fourthNum > maxValue)
            {
                maxValue = fourthNum;
            }

            if (fifthNum > maxValue)
            {
                maxValue = fifthNum;
            }

            Console.WriteLine();
            Console.WriteLine("The BIGGEST number is {0}.", maxValue);
                       
        }
    }
}
