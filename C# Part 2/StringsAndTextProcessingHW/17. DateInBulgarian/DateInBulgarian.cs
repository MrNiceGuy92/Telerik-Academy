namespace DateInBulgarian
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

//Problem 17. Date in Bulgarian

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

    class DateInBulgarian
    {
        static void Main()
        {
            Console.WriteLine("Input date in format dd.MM.yyyy hh:mm:ss");
            string inputDate = Console.ReadLine();
            string format = "dd.MM.yyyy hh:mm:ss";

            DateTime dateValue;

            DateTime.TryParseExact(inputDate, format, null, DateTimeStyles.None, out dateValue);

            DateTime result = dateValue.AddHours(6).AddMinutes(30);
            string result1 = result.ToString(format);

            DateTime dateValue1;
            DateTime.TryParseExact(result1, format, null, DateTimeStyles.None, out dateValue1);

            Console.WriteLine(dateValue);
            Console.WriteLine(dateValue1);


        }
    }

}

