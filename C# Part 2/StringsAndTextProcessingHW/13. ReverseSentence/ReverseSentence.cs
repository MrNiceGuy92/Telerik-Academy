namespace ReverseSentence
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    //Problem 13. Reverse sentence

    //Write a program that reverses the words in given sentence.

    class ReverseSentence
    {
        static List<int> indexList = new List<int>(); //Global list to add indexes of all ',' in sentence
        static List<int> counterlist = new List<int>(); //Global list to add number of words in each sustring

        static void Main()
        {
            string input = "C# is not C++, not PHP and not Delphi!";

            Substrings(input); //Splits sentence in substrings, depending on count of ','

            input = RemovingCommas(input, indexList); //Removing commas in sentence
            input = input.Remove(input.Length - 1, 1); //Removing punctuation mark at end of sentence

            input = ReverseWords(input); //Reversing words
            input = input.Insert(input.Length, "!"); //Insering '!' at end

            string[] splitWords = input.Split(' ');
            var newInput = splitWords.ToList();

            for (int j = 0; j < counterlist.Count - 1; j++)
            {
                newInput.Insert(counterlist[j], ",");
            }

            input = string.Join(" ", newInput);

            //Remove unnecassary space before ','
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ',')
                {
                    input = input.Remove(i - 1, 1);
                }
            }

            Console.WriteLine(input);
        }

        static void Substrings(string input)
        {
            string[] words = new string[indexList.Count];

            for (int i = 0; i < input.Length; i++) //Divide sentence in substrings, separated by ','
            {
                words = input.Split(',');
            }

            int counter = 1; //We distinguish words by " ", so (the number of " " + 1 == number of words in substring)

            for (int j = 0; j < words.Length; j++) //Find number of words in each substring
            {
                for (int i = 0; i < words[j].Length; i++)
                {
                    if (j > 0)
                    {
                        i = words[j - 1].Length - 1;
                    }

                    string symbol = " ";
                    int index = words[j].IndexOf(symbol);

                    while (index != -1)
                    {
                        counter++;
                        index = words[j].IndexOf(symbol, index + 1);
                    }
                    counterlist.Add(counter);
                    counter = 0; //counter = 0, since there is " " after each ','
                    break;
                }
            }
        }

        static string RemovingCommas(string input, List<int> indexList)
        {
            string symbol = ",";
            int index = input.IndexOf(symbol);

            while (index != -1)
            {
                indexList.Add(index);
                index = input.IndexOf(symbol, index + 1);
            }

            for (int i = 0; i < indexList.Count; i++)
            {
                if (i > 0) //After removing the first ',', the sentence gets shorter by one char
                {
                    indexList[i]--;
                }

                input = input.Remove(indexList[i], 1);
            }
            return input;
        }

        static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }

}