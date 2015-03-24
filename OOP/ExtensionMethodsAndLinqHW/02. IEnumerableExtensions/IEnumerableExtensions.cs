namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static void TSum<T>(this IEnumerable<T> smth)
        {
            dynamic sum = 0;
            foreach (var nums in smth)
            {
                sum += nums;
            }

            Console.WriteLine(sum);
        }

        public static void TProduct<T>(this IEnumerable<T> smth)
        {
            dynamic product = 1;
            foreach (var nums in smth)
            {
                product *= nums;
            }

            Console.WriteLine(product);
        }

        public static void TMin<T>(this IEnumerable<T> smth) where T : IComparable<T>
        {
            var initialMin = smth.First();
            foreach (var item in smth)
            {
                if (initialMin.CompareTo(item) > 0)
                {
                    initialMin = item;
                }
            }

            Console.WriteLine(initialMin);
        }

        public static void TMax<T>(this IEnumerable<T> smth) where T : IComparable<T>
        {
            var initialMax = smth.First();
            foreach (var item in smth)
            {
                if (initialMax.CompareTo(item) < 0)
                {
                    initialMax = item;
                }
            }

            Console.WriteLine(initialMax);
        }

        public static void TAverage<T>(this IEnumerable<T> smth)
        {
            dynamic sum = 0;
            dynamic average;

            foreach (var nums in smth)
            {
                sum += nums;
            }

            average = sum / smth.Count();

            Console.WriteLine(average);
        }
    }
}