using System;

namespace ComparingFloats
{
    class ComparingFloats

    {
        static void Main()
        {
            double eps = 0.000001;

            Console.Write("First float number to compare: ");
            double firstDouble = double.Parse(Console.ReadLine());
            Console.Write("Second float number to compare: ");
            double secondDouble = double.Parse(Console.ReadLine());

            bool check = Math.Abs(firstDouble - secondDouble) < eps;

            if (check)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The numbers are NOT equal.");
            }
        }
    }
}
