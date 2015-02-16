//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.


using System;
namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            // A unique approach to the problem (different type of solution)

            Console.Write("Write your number: ");
            int num = Int32.Parse(Console.ReadLine());

            double remainder = num % 1000;

            bool thirdDigitIsSeven = (remainder>699) && (remainder<800);

            if (thirdDigitIsSeven)
            {
                Console.WriteLine("The third digit IS seven.");
            }
            else
            {
                Console.WriteLine("The third digit is NOT seven.");
            }
        }
    }
}
