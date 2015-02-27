namespace LettersCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

//Problem 21. Letters count

//Write a program that reads a string from the console and prints all different letters in 
//the string along with information how many times each letter is found.

    class LettersCount
    {
        static void Main()
        {
            string input = "a !bb c a. c";

            //char[] izlishni = new char[] { ' ', ',', '!', '.', '?', ':', ';', '"', '-' };
            string newInput = input.Trim();

            Console.WriteLine(newInput);

        }
    }

}

