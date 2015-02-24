namespace SubstringInText
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9

    class SubstringInText
    {
        static void Main()
        {
            //Input by hand
            //Console.Write("Input string: ");
            //string text = Console.ReadLine();
            //string keyword = Console.ReadLine();

            //Example from problem
            string text = "We are living in an yellow submarine. We don't have anything else." +
            "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."; 

            string keyword = "in";

            int index = text.ToLower().IndexOf(keyword); //make case insensitive search by converting text to lowercase letters

            int counter = 0;
            while (index != -1)
            {
                counter++;
                index = text.ToLower().IndexOf(keyword, index + 1);
            }

            Console.WriteLine("Number of times keyword appears in text: {0}\n", counter);
        }
    }
}
