namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

//Problem 20. Palindromes

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

    class Palindromes
    {
        static void Main()
        {
            string input = "Here are some examples of palindromes: madam, civic, anana and some others: racecar, malayalam.";

            //Removing punctuation marks inside sentence
            string[] allWords = input
                                .Split(new char[]{' ',',',':','.',';'}, StringSplitOptions.RemoveEmptyEntries);

            var result = new List<string>(allWords);

            foreach (string isPalindrome in allWords)
            {
                for (int i = 0; i < isPalindrome.Length/2; i++)
                {
                    if (isPalindrome[i] != isPalindrome[isPalindrome.Length - i -1])
                    {
                        result.Remove(isPalindrome);
                    }
                }
            }

            Console.WriteLine("All palindromes in sentence:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

