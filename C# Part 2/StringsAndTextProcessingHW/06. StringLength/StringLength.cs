namespace StringLength
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string 
//is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

    class StringLength
    {
        static void Main()
        {
            Console.Write("Input string of max 20 characters: ");
            string input = Console.ReadLine();

            while (input.Length > 20)
            {
                Console.Clear();
                Console.Write("Input string MUST be max 20 characters: ");
                input = Console.ReadLine();
            }

            if (input.Length < 20)
            {
                Console.WriteLine(input + new string('*', 20 - input.Length));

                //Alternatively
                //Console.WriteLine(input.PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
