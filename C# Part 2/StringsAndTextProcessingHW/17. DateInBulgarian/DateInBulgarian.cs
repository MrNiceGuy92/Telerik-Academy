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
            string input = Console.ReadLine();

            DateTime inputDate = Convert.ToDateTime(input, CultureInfo.CreateSpecificCulture("bg-BG"));
	        string format = "MM.yyyy hh:mm:ss";
            inputDate.ToString(format);


            Console.WriteLine(inputDate);
        }
    }

}

