//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("TYPES: 1 -> int; 2 -> double; 3 -> string");
            Console.Write("Please choose a type: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (input)
            {
                case 1: Console.Write("Please enter an integer: ");
                    int someInt = int.Parse(Console.ReadLine());
                    int result = someInt + 1;

                    Console.WriteLine("Result: {0}", result); break;

                case 2: Console.Write("Please enter a value: ");
                    double someDouble = double.Parse(Console.ReadLine());
                    double otherResult = someDouble + 1;

                    Console.WriteLine("Result: {0}", otherResult); break;

                case 3: Console.Write("Please enter a string: ");
                    string someString = Console.ReadLine();
                    string alternativeResult = someString + (char)0x2A;

                    Console.WriteLine("Result: {0}", alternativeResult); break;

                default: Console.WriteLine("Invalid input.");
                    break;
            }

        }
    }
}
