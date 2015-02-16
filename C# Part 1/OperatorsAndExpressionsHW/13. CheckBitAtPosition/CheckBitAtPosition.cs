//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.


using System;

namespace CheckBitAtPosition
{
    class CheckBitAtPosition
    {
        static void Main()
        {
            Console.Write("Choose an integer: ");
            int someInt = Int32.Parse(Console.ReadLine());
            Console.Write("Pick the index of the bit you want to check: ");
            int someIndex = Int32.Parse(Console.ReadLine());

            int mask = 1 << someIndex;
            int nAndMask = someInt & mask;
            int bit = nAndMask >> someIndex;
            
            bool check = (bit == 1);

            if (check)
            {
                Console.Write("Is the bit 1?: ");
                Console.WriteLine("YES");
            }
            else
            {
                Console.Write("Is the bit 1?: ");
                Console.WriteLine("NO");
            }

        }
    }
}
