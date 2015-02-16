using System;

namespace NumbersInInterval
{
    class NumbersInInterval
    {
        static void Main()
        {
            Console.Write("First integer: ");
            uint lowerInterval = uint.Parse(Console.ReadLine());

            Console.Write("Second integer: ");
            uint upperInterval = uint.Parse(Console.ReadLine());

            int numModFiveIsZero = 0;

            for (uint i = lowerInterval; i <= upperInterval; i++)
            {
                if (i % 5 == 0)
                {
                    numModFiveIsZero++;
                }
            }

            Console.WriteLine("There are {0} numbers between {1} and {2}," +
                "whose reminder of the division by 5 is 0.",numModFiveIsZero, lowerInterval,upperInterval);
            Console.WriteLine();
        }
    }
}