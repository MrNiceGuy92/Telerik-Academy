//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IndexOfLetter
{
    static void Main()
    {
        char[] alphabetUppercase;
        string word;

        CreatingAlphabetArray(out alphabetUppercase, out word);

        List<char> alphabetList = new List<char>(alphabetUppercase);
        List<int> result = new List<int>();

        for (int i = 0; i < word.Length; i++)
        {
            if (alphabetList.Contains(word[i]))
            {
                result.Add(alphabetList.IndexOf(word[i]));
            }
        }

        //Printing indexes
        for (int i = 0; i < result.Count; i++) //Reminder: Indexes of (alphabet) array start form 0
        {
            Console.WriteLine("Word[{0}]={1}th index", i , result[i]);
        }
    }

    private static void CreatingAlphabetArray(out char[] alphabetUppercase, out string word)
    {
        alphabetUppercase = new char[26]; //There are 26 letters in the English alphabet

        //Creating arrays of uppercase letters
        int index = 0;
        for (char i = '\u0041'; i <= '\u005A'; i++)
        {
            alphabetUppercase[index] = i;
            index++;
        }

        //Input word
        Console.Write("Write a word: ");
        word = Console.ReadLine().ToUpper();
        Console.WriteLine();
    }
}

//Alternative solution

//static void Main()
//    {
//        char[] lettersArray = new char[26];

//        for (int i = 0; i < lettersArray.Length; i++)
//        {
//            lettersArray[i] = (char)(i + 65);                   //adding letters to the array 
//        }

//        Console.Write("Enter a word: ");
//        string word = Console.ReadLine().ToUpper();
//        Console.Write("The indices of the word {0} are: ", word);

//        for (int i = 0; i < word.Length; i++)
//        {                                                         //going through the word checking for matches
//            for (int j = 0; j < lettersArray.Length; j++)
//            {
//                if (word[i] == lettersArray[j])
//                {
//                    Console.Write("[{0}] ", j);
//                }
//            }
//        }
//        Console.WriteLine();
//    }
