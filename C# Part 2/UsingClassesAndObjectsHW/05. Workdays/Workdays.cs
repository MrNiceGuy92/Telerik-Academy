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
            string format = "dd/MM/yyyy";
            DateTime futureDate = DateTime.ParseExact(inputFutureDate, format, CultureInfo.InvariantCulture);
            GetWorkdays(futureDate);

            DateTime[] holidays = {
                                      01/01,

                                  };

        }

        static void GetWorkdays(DateTime futureDate)
        {
            DateTime currentDate = DateTime.Now;

            System.TimeSpan difference = futureDate.Subtract(currentDate);

            Console.WriteLine(difference.);
        }
    }
}
