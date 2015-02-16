using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string firstStr = "Hello" ;
            Console.WriteLine("First string: {0}", firstStr);
            string secondStr = "World";
            Console.WriteLine("Second string: {0}", secondStr);

            object myObj = firstStr + " " + secondStr;

            string thirdStr = (string)myObj;

            Console.WriteLine();
            Console.WriteLine("Concatenation of the two strings: {0}",thirdStr);

        }
    }
}
