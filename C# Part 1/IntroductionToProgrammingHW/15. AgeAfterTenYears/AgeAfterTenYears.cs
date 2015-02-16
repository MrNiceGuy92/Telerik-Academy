using System;

namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("What is your birthday (dd/mm/yy)?");
            string birthday = Console.ReadLine();

            DateTime convertedDate = DateTime.Parse(birthday);
            DateTime currentDateAndTime = DateTime.Now;

            TimeSpan span = currentDateAndTime.Subtract(convertedDate);

            Console.WriteLine("You are {0} years old", (int)span.TotalDays/365);
            Console.WriteLine("After 10 years you will be {0} years old :(", (int)(span.TotalDays/365)+10);
            


        }
    }
}
