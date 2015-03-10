namespace SquareRoot
{
//Problem 1. Square root

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

    using System;
    using System.Text;

    class SquareRoot
    {
        static void Main()
        {
            try
            {
                Console.Write("Your integer number: ");
                int someInt = int.Parse(Console.ReadLine());

                GetSquareRoot(someInt);
            }
            catch (FormatException)
            {
                //The input is not of type int
                Console.WriteLine("Invalid number. Number must be integer.");
            }
            
            
        }

        static void GetSquareRoot(int someInt)
        {
             try
            {
                decimal result = (decimal)Math.Sqrt(someInt);
                Console.Write("Result: ");
                Console.WriteLine(String.Format("{0}",result));
            }
            catch (OverflowException)
            {
                //The input is a negative number
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}

