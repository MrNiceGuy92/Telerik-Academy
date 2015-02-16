using System;

namespace ASCIITable
{
    class ASCIITable
    {
        static void Main()
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.Write("The ASCII symbol for {0} is ", i);
                Console.WriteLine((char)i);
            }
        }
    }
}
