namespace ReverseString
{
    using System;    
    using System.Text;

//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.

    class ReverseString
    {
        static void Main()
        {
            Console.Write("Input string: ");
            string input = Console.ReadLine();

            StringBuilder reversedStr = new StringBuilder(input.Length);

            Console.Write("Reversed string: ");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedStr.Append(input[i]);
            }
            Console.WriteLine(reversedStr.ToString());

            //Alternatively with .NET method
            //Console.Write("Input string: ");
            //string input = Console.ReadLine();

            //char[] charArray = input.ToCharArray();

            //Array.Reverse(charArray);

            //Console.Write("Reversed string: ");
            //foreach (char character in charArray)
            //{
            //    Console.Write(character);
            //}
            //Console.WriteLine();
        }
    }
}

