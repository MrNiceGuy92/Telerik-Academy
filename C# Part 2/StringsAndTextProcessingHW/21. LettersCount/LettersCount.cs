namespace LettersCount
{
    using System;
    using System.Collections.Generic;
    using System.Text;

//Problem 21. Letters count

//Write a program that reads a string from the console and prints all different letters in 
//the string along with information how many times each letter is found.

    class LettersCount
    {
        static void Main()
        {
            string input = "aa $%&*bbb AcAgc bAcdbAa A.@#%^&!g"; //a=3 b=5 A=5 c=3 g=2 d=1

            for (int i = 0; i < input.Length; ) //Removing all chars which are not letters
            {
                if (char.IsLetter(input[i]))
                {
                    i++;
                    continue;
                }
                else
                {
                    input = input.Remove(i, 1);
                }
            }

            int[] counts = new int[input.Length]; //Here input.Length = 18, since we have not yet removed same letters
            int counter = 1;
            for (int i = 0; i < input.Length; i++)
            {
                counter = 1;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        counter++;
                        counts[i] = counter;
                        input = input.Remove(j, 1);
                        j = i;
                    }
                }
            }

            Array.Resize(ref counts, input.Length); //Resizing array to correct length

            for (int i = 0; i < counts.Length; i++) //Here we replace all zeros in array (if a letter is unique in string) with ones
            {
                if (counts[i] == 0)
                {
                    counts[i] = 1;
                }
            }

            Console.WriteLine("All different letters in string: {0}.\n", input);
            Console.WriteLine("The number of times each letter appears:");
            //Printing
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("Letter: {0}, count: {1}", input[i], counts[i]);
            }


        }
    }
}

   //Alternative solution
   //Console.WriteLine("Enter string");
//string text = "aa $%&*bbb AcAcA bAcdbga A.@#%^&!g";

//while (text != "")
//{
//    // get first letter and remove from text
//    char letter = text[0];
//    text = text.Substring(1);

//    // set counter including first letter and start searching
//    int letterCount = 1;
//    for (int i = 0; i < text.Length; i++)
//    {
//        if (text[i] == letter)
//        {
//            text = text.Remove(i, 1);   // removes letter
//            i--;    // starts next check from removed letter position
//            letterCount++;
//        }
//    }

//    if (Char.IsLetter(letter))  // print only letters
//    {
//        Console.WriteLine("char: {0}, {1} times", letter, letterCount);
//    }
//}