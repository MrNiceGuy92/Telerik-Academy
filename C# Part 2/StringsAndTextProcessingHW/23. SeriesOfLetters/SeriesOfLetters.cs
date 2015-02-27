namespace SeriesOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

    class SeriesOfLetters
    {
        static void Main()
        {
            string input = "aaaaabbbbbcdddeeeedssaa";

            StringBuilder result = new StringBuilder();

            char start = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j+=2)
                {
                    if (input[i] == input[j])
                    {                        
                        i = j;
                        j--;
                        input = input.Remove(j, 1);
                    }
                    else
                    {
                        i = j;
                        j--;
                    }
                }
            }

            Console.WriteLine(input);
        }
    }

}
