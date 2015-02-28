namespace ParseTags
{
    using System;
    using System.Text; 

//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

    class ParseTags
    {
        static void Main()
        {
            //User input
            //string text = Console.ReadLine();

            //Example from problem
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            string firstKeyword = "<upcase>";
            string secondKeyword = "</upcase>";

            int firstIndex = text.IndexOf(firstKeyword);
            int secondIndex = text.IndexOf(secondKeyword);

            while (firstIndex != -1 && secondIndex != -1)
            {
                string someSubstring = text.Substring(firstIndex + firstKeyword.Length, secondIndex - firstKeyword.Length - firstIndex);
                string upperSubstring = someSubstring.ToUpper();

                text = text.Replace(someSubstring, upperSubstring);

                firstIndex = text.IndexOf(firstKeyword, firstIndex + 1);
                secondIndex = text.IndexOf(secondKeyword, secondIndex + 1);
            }

            Console.WriteLine("Transformed text: ");
            Console.WriteLine(text);
        }
    }
}
