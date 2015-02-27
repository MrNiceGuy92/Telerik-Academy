namespace WordDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //Problem 14. Word dictionary

    //A dictionary is stored as a sequence of text lines containing words and their explanations.
    //Write a program that enters a word and translates it by using the dictionary.

    class WordDictionary
    {
        static void Main()
        {
            string input = "CLR";

            Dictionary<string, string> ourDict = new Dictionary<string, string>();

            ourDict.Add(".NET", "platform for applications from Microsoft");
            ourDict.Add("CLR", "managed execution environment for .NET");
            ourDict.Add("namespace", "hierarchical organization of classes");

            if (ourDict.ContainsKey(input))
            {
                string value = ourDict[input];
                Console.WriteLine("Definition: {0}",value);
            }
            else
            {
                Console.WriteLine("No such word in dictionary.");
            }
        }
    }
}