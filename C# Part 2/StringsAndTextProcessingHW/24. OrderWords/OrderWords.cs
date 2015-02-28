namespace OrderWords
{
    using System;
    using System.Collections.Generic;
    using System.Text;

//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

    class OrderWords
    {
        static void Main()
        {
            Console.WriteLine("Enter words, separated by space:");
            string words = Console.ReadLine();

            string[] result = words
                            .Split(' ');

            for (int i = 0; i < result.Length - 1; i++)
            {
                int index = result[i].CompareTo(result[i + 1]);

                if (index > 0)
                {
                    string temp = result[i];
                    result[i] = result[i + 1];
                    result[i + 1] = temp;
                }
            }

            Console.WriteLine();
            Console.WriteLine("In alphabetical order:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
