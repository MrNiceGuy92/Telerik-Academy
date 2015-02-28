namespace ForbiddenWords
{
    using System;
    using System.Collections.Generic;    
    using System.Text;

    //Problem 9. Forbidden words

    //We are given a string containing a list of forbidden words and a text containing some of these words.
    //Write a program that replaces the forbidden words with asterisks.

    class ForbiddenWords
    {
        static void Main()
        {
            //User Input
            //string text = Console.ReadLine();

            //Example from problem
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework" +
            "4.0 and is implemented as a dynamic language in CLR.";

            string[] forbidden = new string[] { "PHP", "Microsoft", "CLR" };

            for (int i = 0; i < forbidden.Length; i++)
            {
                if (text.Contains(forbidden[i]))
                {
                    text = text.Replace(forbidden[i], new string('*', forbidden[i].Length));
                }
            }

            Console.WriteLine("Transformed text:");
            Console.WriteLine(text);
        }
    }

}