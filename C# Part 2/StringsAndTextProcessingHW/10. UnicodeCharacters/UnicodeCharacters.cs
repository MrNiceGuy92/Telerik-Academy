namespace UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Text;

//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

    class UnicodeCharacters
    {
        static void Main()
        {
            //User input
            //string text = Console.ReadLine();

            //Example from problem
            string text = "Hi!";

            char[] charArray = text.ToCharArray();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < charArray.Length; i++)
            {
                result.Append("\\u" + ((int)charArray[i]).ToString("X4")); 
            }

            Console.WriteLine("Text in unicode:");
            Console.WriteLine(result);
        }
    }

}