//Problem 17.* Calculate GCD

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;

namespace GCD
{
    class GCD
    {
        static void Main()
        {
            Console.Write("First integer: ");
            int firstInt = int.Parse(Console.ReadLine());

            Console.Write("Second integer: ");
            int secondInt = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int remainder;

            if (firstInt > secondInt)
            {
                do
                {
                    remainder = firstInt % secondInt;
                    if (remainder == 0)
                    {
                        Console.WriteLine("The GCD is {0}.", secondInt);
                        break;
                    }

                    firstInt = secondInt;
                    secondInt = remainder;

                } while (remainder != 0);
            }
            else if (secondInt > firstInt)
            {
                do
                {
                    remainder = secondInt % firstInt;
                    if (remainder == 0)
                    {
                        Console.WriteLine("The GCD is {0}.", firstInt);
                        break;
                    }

                    secondInt = firstInt;
                    firstInt = remainder;

                } while (remainder != 0);
            }
        }
    }
}
