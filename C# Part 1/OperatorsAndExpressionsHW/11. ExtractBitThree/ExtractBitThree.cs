//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.


using System;

namespace ExtractBitThree
{
    class ExtractBitThree
    {
        static void Main()
        {
            Console.Write("Choose an unsigned integer: ");
            uint chosenInt = uint.Parse(Console.ReadLine());

            int placeOfBit = 3;

            int mask = 1 << placeOfBit;        
            int nAndMask = (int)chosenInt & mask;  
            int bit = nAndMask >> placeOfBit;
            Console.WriteLine("The bit at the third place is {0}", bit);
               

        }
    }
}
