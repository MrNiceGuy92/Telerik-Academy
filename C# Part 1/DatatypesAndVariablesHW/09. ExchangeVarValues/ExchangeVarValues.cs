using System;

namespace ExchangeVarValues
{
    class ExchangeVarValues
    {
        static void Main()
        {
            int A = 5;
            int B = 10;

            int C;

            Console.WriteLine("Initial value of A: {0}", A);
            Console.WriteLine("Initial value of B: {0}",B);

            C = A;
            A = B;
            B = C;

            Console.WriteLine("Value of A after exchange: {0}",A);
            Console.WriteLine("Value of B after exchange: {0}",B);
        }
    }
}
