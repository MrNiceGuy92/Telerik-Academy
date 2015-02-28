namespace WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.Text; 

//Problem 22. Words count

//Write a program that reads a string from the console and lists all different words in the 
//string along with information how many times each word is found.
    
    class WordsCount
    {
        static void Main()
        {
            string input = "Abu Dhabi Abu Dhabi, Sofia, Sofia SOFIA."; //Abu = 2; Dhabi = 2; Sofia = 2; SOFIA = 1

            char[] separators = new char[] { ' ', ',', '.' };
            string[] capitals = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int counter = 0;
            var capitalList = new List<string>(capitals); //Converting to list, so we can use .RemoveAt() later
            int[] count = new int[capitalList.Count]; //An array to save the count of each word

            for (int i = 0; i < capitalList.Count; i++)
            {
                counter = 1;
                for (int j = i + 1; j < capitalList.Count; j++)
                {
                    if (capitalList[i] == capitalList[j])
                    {
                        counter++;
                        count[i] = counter;
                        capitalList.RemoveAt(j);
                        j++;
                    }
                }
            }

            Array.Resize(ref count, capitalList.Count); //Resizing to correct length

            for (int i = 0; i < count.Length; i++) //Here we replace all zeros in array (if a word is unique in string) with ones
            {
                if (count[i] == 0)
                {
                    count[i] = 1;
                }
            }

            Console.WriteLine("All different words:");
            for (int i = 0; i < capitalList.Count; i++)
            {
                Console.WriteLine("Word: {0}; Count: {1}", capitalList[i] ,count[i]);
            }
        }
    }
}
