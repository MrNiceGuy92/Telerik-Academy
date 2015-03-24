namespace _06.DivisibleBy3And7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Divisibility
    {
        public static void Main()
        {
            int[] numbers = new int[] { 21, 7, 3, 147, 7203, 90, 120 };

            DivisibilityWithLambda(numbers);

            Console.WriteLine("Numbers from array divisible by 7 and 3 (with LINQ):\n");
            Console.WriteLine(string.Join(" ", DivisibleWithLINQ(numbers)));
        }

        private static void DivisibilityWithLambda(int[] numbers)
        {
            var divivisibleBy7And3 = numbers
                .Where(x => (x % 7 == 0) && (x % 3 == 0))
                .ToList();

            Console.WriteLine("Numbers from array divisible by 7 and 3 (with LAMBDA):\n");
            foreach (var item in divivisibleBy7And3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
        }

        private static IEnumerable<int> DivisibleWithLINQ(int[] numbers)
        {
            var divBy7And3 =
                from num in numbers
                where (num % 7 == 0) && (num % 3 == 0)
                select num;

            return divBy7And3;
        }
    }
}