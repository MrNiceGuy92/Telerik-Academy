//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n = 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).


using System;

namespace PrimeNumber
{
    class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter the number you want to check: ");
        int number = Int32.Parse(Console.ReadLine());
        bool isPrime = true;
        int maxDivider = (int)Math.Sqrt(number);
        int initialDivider = 2;

        
        while (isPrime && (initialDivider <= maxDivider))
        {
            if (number % initialDivider == 0)
            {
                Console.WriteLine("The number is NOT prime.");
                initialDivider++;
                isPrime = false;
            }

            else
            {
                Console.WriteLine("The number IS prime.");
                break;
            }
        }

        if (number < 2)
        {
            Console.WriteLine("The number is NOT prime.");
        }
        else if (number == 2 || number == 3)
        {
            Console.WriteLine("The number IS prime.");
        }
    }
}
}
