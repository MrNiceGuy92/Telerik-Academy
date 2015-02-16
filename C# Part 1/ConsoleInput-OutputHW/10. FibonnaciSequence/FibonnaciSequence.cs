//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the
//Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 
//144, 233, ….
//Note: You may need to learn how to use loops.


using System;

namespace FibonnaciSequence
{
    class FibonnaciSequence
    {
        static void Main()
        {
            Console.Write("Number of members in Fibonnaci Sequence: ");
            int someNum = Int32.Parse(Console.ReadLine());

            int firstMember = 0;
            int secondMember = 1;
            int sum = 1;
            Console.Write(0 + ",");

            for (int i = 1; i <= someNum - 1; i++)
            {
                Console.Write(sum + ",");
                sum = secondMember + firstMember;
                firstMember = secondMember;
                secondMember = sum;
            }
            Console.WriteLine();
        }
    }
}
