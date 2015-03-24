namespace StringBuilderSubstring
{
    using System;
    using System.Text; 

    public class Test
    {
        static void Main()
        {
            Console.WriteLine("Stringbuilder extension test:\n");

            var someStringBuilder = new StringBuilder();
            someStringBuilder.Append("Bulgaria");
            var result = someStringBuilder.Substring(0, 3);

            Console.WriteLine(result.ToString());   
        }
    }
}
