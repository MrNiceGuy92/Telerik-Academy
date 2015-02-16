using System;

namespace NullableTypes
{
    class NullableTypes
    {
        static void Main()
        {
            int? nullInt = null;
            double? nullDouble = null;

            Console.WriteLine("Integer null value: {0} \nand Double null value: {1}", nullInt + 500, nullDouble + 500);

            nullInt += 123;
            nullDouble += 12.3;

            Console.WriteLine();
            Console.WriteLine("Integer after addition: {0} \nand Double after addition: {1}",nullInt, nullDouble);

            


        }
    }
}
