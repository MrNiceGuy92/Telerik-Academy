namespace SumIntegers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //Problem 6. Sum integers

    //You are given a sequence of positive integer values written into a string, separated by spaces.
    //Write a function that reads these values from given string and calculates their sum.

    class SumIntegers
    {
        static void Main()
        {
            //User input
            //Console.Write("Please input integers, separated by space: ");
            //string input = Console.ReadLine();

            //Example from problem
            string input = "43 68 9 23 318";

            string[] result = input.Split(' ');
            int sum = 0;

            for (int i = 0; i < result.Length; i++)
            {
                sum += int.Parse(result[i]);
            }

            Console.WriteLine("The sum of integers is: {0}", sum);
        }
    }
}
