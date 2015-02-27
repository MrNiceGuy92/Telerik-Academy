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
            Console.Write("Input second date (dd.MM.yyyy): ");
            string secondDate = Console.ReadLine();

            DateTime parsedDate1 = DateTime.ParseExact(firstDate, format, CultureInfo.InvariantCulture);
            DateTime parsedDate2 = DateTime.ParseExact(secondDate, format, CultureInfo.InvariantCulture);

            TimeSpan result = parsedDate2.Subtract(parsedDate1);

            if (result < 0)
            {
                result *= -1;
            }

            Console.WriteLine("Days inbetween: {0}", result.TotalDays);
        }

    }
}
