namespace RangeExceptions
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class Test
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            DateTime lowerBoundaryDate = new DateTime(1980, 1, 1);
            DateTime upperBoundaryDate = new DateTime(2013, 12, 31);

            const int LowerBoundary = 1;
            const int UpperBoundary = 100;

            try
            {
                int someNum = 0;

                if (someNum < 1 || someNum > 100)
                {
                    string message = string.Format("The number must be in the range: [{0} - {1}].", LowerBoundary, UpperBoundary);
                    throw new InvalidRangeException<int>(message, LowerBoundary, UpperBoundary);
                }
            }
            catch (InvalidRangeException<int> smth)
            {
                Console.WriteLine(smth.Message);
            }

            Console.WriteLine(new string('-', 30));

            try
            {
               DateTime someDate = DateTime.Now;
               if (someDate < new DateTime(1980, 1, 1) || someDate > new DateTime(2013, 12, 31))
               {
                   string message = string.Format("The date must be in the range: [{0} - {1}].", lowerBoundaryDate.ToString("dd/MM/yyyy"), upperBoundaryDate.ToString("dd/MM/yyyy"));
                   throw new InvalidRangeException<DateTime>(message, lowerBoundaryDate, upperBoundaryDate);
               }
            }
            catch (InvalidRangeException<DateTime> smth)
            {
                Console.WriteLine(smth.Message);
            }

            Console.WriteLine();
        }
    }
}
