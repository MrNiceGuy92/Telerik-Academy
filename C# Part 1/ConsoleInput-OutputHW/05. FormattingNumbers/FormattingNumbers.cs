//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.


using System;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("Enter number A (0<A<500): ");
            int numberA = int.Parse(Console.ReadLine());

            bool check = numberA >0 && numberA <500;

            if (check)
            {
                Console.Write("Write a floating-point number B: ");
                double numberB = double.Parse(Console.ReadLine());

                Console.Write("Write a floating-point number C: ");
                double numberC = double.Parse(Console.ReadLine());

                string binaryA = Convert.ToString(numberA, 2);
                binaryA = binaryA.PadLeft(10, '0');

                Console.WriteLine("{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3} ", numberA, binaryA, numberB, numberC);


            }
            else
            {
                Console.WriteLine("Wrong input for number A!");
            }
        }
    }
}
