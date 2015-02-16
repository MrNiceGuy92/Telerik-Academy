//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be 
//divided (without remainder) by 7 and 5 at the same time.


using System;
namespace DivideBySevenAndFive
{
    class DivideBySevenAndFive
    {
        static void Main()
        {
            Console.Write("Write your number: ");
            int num = Int32.Parse(Console.ReadLine());

            bool divByFive = (num % 5 == 0);
            bool divBySeven = (num % 7 == 0);
            bool notZero = (num != 0);

            if (divByFive && divBySeven && notZero)
            {
                Console.WriteLine("Your number CAN be divided by five and seven without reaminder.");
            }
            else
            {
                Console.WriteLine("Your number CANNOT be divided by 5 and 7 SIMULTANEOUSLY.");
            }
        }
    }
}
