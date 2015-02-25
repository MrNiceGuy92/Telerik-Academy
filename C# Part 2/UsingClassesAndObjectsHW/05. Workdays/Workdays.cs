namespace Workdays
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

//Problem 5. Workdays

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

    class Workdays
    {
        static void Main()
        {
            Console.Write("Choose a future date (dd/MM/yyyy): ");
            string inputFutureDate = Console.ReadLine(); ;
            string format = "dd/MM/yyyy"; //format of date
            DateTime futureDate = DateTime.ParseExact(inputFutureDate, format, CultureInfo.InvariantCulture);

            DateTime currentDate = DateTime.Now.Date;

            var dates = new List<DateTime>(); //empty list to add DATES inbetween current and future date
            var daysOfWeek = new List<DayOfWeek>(); //empty list to add DAYS inbetween current and future date

            //List of some Bulgarian holidays in 2015 (Baba Marta, Liberation Day, St. George Day):
            var holidays = new List<DateTime>(){new DateTime(2015, 03, 03), new DateTime(2015, 03, 01), new DateTime(2015, 05, 06)};

            for (var date = currentDate; date <= futureDate; date = date.AddDays(1)) //'<=' since futureDate is included
            {
                dates.Add(date);
                daysOfWeek.Add(date.DayOfWeek);
                for (int i = 0; i < holidays.Count; i++)
                {
                    if (dates.Contains(holidays[i]))
                    {
                        dates.Remove(date);
                        daysOfWeek.Remove(date.DayOfWeek);
                    }
                    
                }
            }
            daysOfWeek.Remove(DayOfWeek.Saturday); //Removing Saturday
            daysOfWeek.Remove(DayOfWeek.Sunday); //Removing Sunday

            Console.WriteLine("\nTotal number of working days: {0}", daysOfWeek.Count);
        }
    }
}
