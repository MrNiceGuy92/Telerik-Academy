//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.


using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Write a four-digit number: ");
            int number = Int32.Parse(Console.ReadLine());

            int firstDigit = number / 1000;
            int secondDigit = (number % 1000)/100; 
            int thirdDigit = (number % 100)/10;
            int fourthDigit = number % 10;

            //Part 1

            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            Console.WriteLine("The sum of the digits is: {0}",sum);

            //Part 2

            Console.WriteLine("Reversed order: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit );

            //Part 3

            Console.WriteLine("Last digit in first position: {0}{1}{2}{3}", 
                fourthDigit, firstDigit, secondDigit, thirdDigit);

            //Part 4

            Console.WriteLine("Exchange second and third digit: {0}{1}{2}{3}", 
                firstDigit,thirdDigit,secondDigit,fourthDigit);
            

        }
    }
}
