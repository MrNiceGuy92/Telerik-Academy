namespace LeapYear
{

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

    class LeapYear
    {
        static void Main()
        {
            Console.Write("Input year: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeap = DateTime.IsLeapYear(year);

            Console.WriteLine("Is it a leap year?: {0}", isLeap);
        }
    }
}
