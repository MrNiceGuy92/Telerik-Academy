namespace SeriesOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Text;

//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

    class SeriesOfLetters
    {
        static void Main()
        {
            //Use example from problem (or enter your own solution)
            string input = "aaaaabbbbbcdddeeeedssaa";

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        input = input.Remove(j, 1);
                        j--;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            Console.WriteLine("Result: {0}", input);
        }
    }
}
