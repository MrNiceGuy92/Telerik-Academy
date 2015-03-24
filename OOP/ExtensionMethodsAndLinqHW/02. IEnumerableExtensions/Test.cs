namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Test
    {
        static void Main()
        {
            var ints = new List<int> { 10, 20, 30 };

            Console.WriteLine("IEnumerable extension tests:\n");

            Console.Write("Extension Sum: ");
            ints.TSum<int>();

            Console.Write("Extension Product: ");
            ints.TProduct<int>();

            Console.Write("Extension Min: ");
            ints.TMin<int>();

            Console.Write("Extension Max: ");
            ints.TMax<int>();

            Console.Write("Extension Average: ");
            ints.TAverage<int>();

            Console.WriteLine();
        }
    }
}
