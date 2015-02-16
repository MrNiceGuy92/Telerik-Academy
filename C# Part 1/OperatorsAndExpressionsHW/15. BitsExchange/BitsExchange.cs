//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

// Reshih zadachata s masivi. Kakto kaza Ivailo: "teq bitovi operacii ne ni trqbvat" haha

using System;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {

            Console.Write("Choose a number: ");
            UInt32 number = UInt32.Parse(Console.ReadLine());

            string binRepresentation = Convert.ToString(number, 2).PadLeft(32,'0');
            
            Console.WriteLine();
            Console.WriteLine("Your number in binary form: {0}", binRepresentation);

            char[] arrOfChar = binRepresentation.ToCharArray();
            Array.Reverse(arrOfChar);

            Console.WriteLine();

            int[] arrOfNum = new int[arrOfChar.Length];

            for (int i = 0; i < arrOfNum.Length; i++)
            {
                arrOfNum[i] = arrOfChar[i] - '0';
            }

            int temp;
            for (int i = 0; i < 3; i++)
            {
                temp = arrOfNum[3 + i];
                arrOfNum[3 + i] = arrOfNum[24 + i];
                arrOfNum[24 + i] = temp;
            }
           
            Console.Write("Binary result: ");

            Array.Reverse(arrOfNum);
            string resultAsString = string.Join("", arrOfNum);
            Console.WriteLine(resultAsString);

            Console.WriteLine();
            uint result = Convert.ToUInt32(resultAsString, 2);
            Console.Write("Result: ");
            Console.WriteLine(result);

            Console.WriteLine();

        }
    }
}
