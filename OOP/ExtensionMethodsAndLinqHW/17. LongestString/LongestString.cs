namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LongestString
    {
        static void Main()
        {
            string[] someArray = new string[]
            {
                "Christopher",
                "Marko",
                "Picaso",
                "Mona Lisa"
            };

            var longestString = someArray
                .OrderByDescending(x => x.Length)
                .First();

            Console.WriteLine("Longest string in array:\n");
            Console.WriteLine(longestString);
        }
    }
}
