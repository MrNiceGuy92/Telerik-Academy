namespace DateDifference
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

    class DateDifference
    {
        static void Main()
        {
            Console.Write("Input first date (dd.MM.yyyy): ");
            string firstDate = Console.ReadLine(); 
            string format = "dd.MM.yyyy"; //format of date
            Console.Write("Input first date (dd.MM.yyyy): ");
            string secondDate = Console.ReadLine(); 
            DateTime dateValue1;
            DateTime dateValue2;
            //We use TryParse to avoid exceptions, if input is in wrong format 
            DateTime.TryParseExact(firstDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue1);
            DateTime.TryParseExact(secondDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue2);

            TimeSpan result = dateValue2.Subtract(dateValue1);

            Console.WriteLine("Days inbetween: {0}",result.TotalDays);
        }
    }
}
