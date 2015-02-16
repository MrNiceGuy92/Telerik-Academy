//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the 
//value v at the position p from the binary representation of n while preserving all other bits in n.


using System;

namespace ModifyBitAtPosition
{
    class ModifyBitAtPosition
    {
        static void Main()
        {
            Console.Write("Choose an integer: ");
            int someInt = Int32.Parse(Console.ReadLine());
            Console.Write("Pick the index of the bit you want to check: ");
            int someIndex = Int32.Parse(Console.ReadLine());
            Console.Write("Choose a bit value (0 or 1): ");
            int someBit = Int16.Parse(Console.ReadLine());

            if (someBit == 0)
            {
                int mask = ~(1 << someIndex);
                int result = someInt & mask;

                Console.WriteLine("Result: {0}", result); 
            }
            else if (someBit == 1)
            {
                int mask = 1 << someIndex;
                int result = someInt | mask;

                Console.WriteLine("Result: {0}", result);   
            }
            else
            {
                Console.WriteLine("Wrong input.");
            }

        }
    }
}
