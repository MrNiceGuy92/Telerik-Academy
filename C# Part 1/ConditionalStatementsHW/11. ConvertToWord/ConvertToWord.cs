//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;
using System.Collections.Generic;
namespace ConvertToWord
{
    class ConvertToWord
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            int ones = input % 10;
            int tens = (input % 100) - (input % 10);
            int hundreds = input / 100;

            int teens = (input % 100) - ((input % 100) / 100);

            switch (input)
            {
                case 11: Console.WriteLine("Eleven"); break;
                case 12: Console.WriteLine("Twelve"); break;
                case 13: Console.WriteLine("Thirteen"); break;
                case 14: Console.WriteLine("Fourteen"); break;
                case 15: Console.WriteLine("Fifteen"); break;
                case 16: Console.WriteLine("Sixteen"); break;
                case 17: Console.WriteLine("Seventeen "); break;
                case 18: Console.WriteLine("Eighteen "); break;
                case 19: Console.WriteLine("Nineteen"); break;
                default: Console.Write("");
                    break;
            }

            bool check = (input >= 11) && (input <= 19);
            bool secondCheck = (11 <= teens) && (teens <= 19);

            if (ones != 0 && !check && !secondCheck)
            {
                switch (hundreds)
                {
                    case 1: Console.Write("One hundred and "); break;
                    case 2: Console.Write("Two hundred and "); break;
                    case 3: Console.Write("Three hundred and "); break;
                    case 4: Console.Write("Four hundred and "); break;
                    case 5: Console.Write("Five hundred and "); break;
                    case 6: Console.Write("Six hundred and "); break;
                    case 7: Console.Write("Seven hundred and "); break;
                    case 8: Console.Write("Eight hundred and "); break;
                    case 9: Console.Write("Nine hundred and "); break;
                    default: Console.Write("");
                        break;
                }

                switch (tens)
                {
                    case 20: Console.Write("Twenty "); break;
                    case 30: Console.Write("Thirty "); break;
                    case 40: Console.Write("Forty "); break;
                    case 50: Console.Write("Fifty "); break;
                    case 60: Console.Write("Sixty "); break;
                    case 70: Console.Write("Seventy "); break;
                    case 80: Console.Write("Eighty "); break;
                    case 90: Console.Write("Ninety "); break;
                    default: Console.Write("");
                        break;
                }

                switch (ones)
                {
                    case 1: Console.WriteLine("One"); break;
                    case 2: Console.WriteLine("Two"); break;
                    case 3: Console.WriteLine("Three"); break;
                    case 4: Console.WriteLine("Four"); break;
                    case 5: Console.WriteLine("Five"); break;
                    case 6: Console.WriteLine("Six"); break;
                    case 7: Console.WriteLine("Seven"); break;
                    case 8: Console.WriteLine("Eight"); break;
                    case 9: Console.WriteLine("Nine"); break;
                    default: Console.WriteLine("");
                        break;
                }
            }
            else if (ones == 0)
            {
                switch (input)
                {
                    case 0: Console.WriteLine("Zero"); break;
                    case 10: Console.WriteLine("Ten"); break;
                    case 100: Console.WriteLine("One hundred"); break;
                    case 20: Console.WriteLine("Twenty"); break;
                    case 200: Console.WriteLine("Two hundred"); break;
                    case 30: Console.WriteLine("Thirty"); break;
                    case 300: Console.WriteLine("Three hundred"); break;
                    case 40: Console.WriteLine("Forty"); break;
                    case 400: Console.WriteLine("Four hundred"); break;
                    case 50: Console.WriteLine("Fifty"); break;
                    case 500: Console.WriteLine("Five hundred"); break;
                    case 60: Console.WriteLine("Sixty"); break;
                    case 600: Console.WriteLine("Six hundred"); break;
                    case 70: Console.WriteLine("Seventy"); break;
                    case 700: Console.WriteLine("Seven hundred"); break;
                    case 80: Console.WriteLine("Eighty"); break;
                    case 800: Console.WriteLine("Eight hundred"); break;
                    case 90: Console.WriteLine("Ninety"); break;
                    case 900: Console.WriteLine("Nine hundred"); break;
                    default: Console.WriteLine("");
                        break;
                }
            }

            Console.WriteLine();
        }
    }
}
