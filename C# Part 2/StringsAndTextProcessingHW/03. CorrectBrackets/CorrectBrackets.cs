namespace CorrectBrackets
{
    using System;
    using System.Text;

//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

    class CorrectBrackets
    {
        static void Main()
        {
            Console.Write("Input expression: ");
            string expression = Console.ReadLine();

            int counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    counter++;
                }
                else if (expression[i] == ')')
                {
                    counter--;
                }
            }

            if (counter < 0 ||counter != 0)
            {
                Console.WriteLine("\nInvalid expression.");
            }
            else if (counter == 0)
            {
                Console.WriteLine("\nThe expression is valid.");
            }
        }
    }
}
