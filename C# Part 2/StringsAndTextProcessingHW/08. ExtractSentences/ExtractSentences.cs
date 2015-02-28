namespace ExtractSentences
{
    using System;
    using System.Collections.Generic;
    using System.Text; 

//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.

    class ExtractSentences
    {
        static void Main()
        {
            //User input
            //string text = Console.ReadLine();

            //Example from problem
            string text = "We are living in an yellow submarine. We don't have anything else." +
            "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            int length = NumberOfSentences(text); //Number of sentences in text
            string[] allSentences = new string[length]; //String array of sentences
            allSentences = text.Split('.');

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < allSentences.Length; i++)
            {
                string key = " in "; //separated by non-letter symbols -> " "

                int index = allSentences[i].IndexOf(key);
                if (index > 0)
                {
                    result.Append(allSentences[i] + ".");
                }
            }

            Console.WriteLine("Sentences containing the word \"in\":\n");
            Console.WriteLine(result);
        }

        static int NumberOfSentences(string text)
        {
            string key = ".";

            int index = text.IndexOf(key);

            int counter = 0;
            while (index != -1)
            {
                counter++;
                index = text.IndexOf(key, index + 1);
            }

            return counter;
        }
    }
}