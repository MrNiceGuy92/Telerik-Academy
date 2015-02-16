//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.


using System;

namespace ExtractBitFromInt
{
    class ExtractBitFromInt
    {
        static void Main()
        {
            Console.Write("Choose an integer: ");
            int someInt = Int32.Parse(Console.ReadLine());
            Console.Write("Pick the index of the bit you want to extract: ");
            int someIndex = Int32.Parse(Console.ReadLine());
                          
            int mask = 1 << someIndex;        
            int nAndMask = someInt & mask;  
            int bit = nAndMask >> someIndex;
            Console.WriteLine("The bit at position {0} is {1}.", someIndex, bit);
            
        }
    }
}
