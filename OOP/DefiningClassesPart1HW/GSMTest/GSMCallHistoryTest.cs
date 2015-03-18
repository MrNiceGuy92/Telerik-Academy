namespace GSMTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using MobilePhoneData;

    public class GSMCallHistoryTest
    {

        public static GSM testGSM = new GSM("Sony Ericson", "Sony Corp.", "Lucky dude 2", 679.99M);

        public static DateTime testCall1Date = DateTime.Parse("08/03/2015 19:15:30");
        public static DateTime testCall2Date = DateTime.Parse("09/03/2015 14:07:18");
        
        public static Call[] testCalls = 
        {
            new Call(testCall1Date, "0888111111", 30.0M),
            new Call(testCall2Date, "0888222222", 45.0M),
            
        };

        public static void CreateCalltestHistory()
        {
            for (int i = 0; i < testCalls.Length; i++)
            {
                testGSM.AddCalls(testCalls[i]); 
            }
        }

        public static void DisplayCalltestHistory()
        {
            Console.WriteLine(testGSM.PrintCallHistory()); 
        }

        public static void CalculateAndPrintTestcallsPrice()
        {
            decimal price = testGSM.TotalCost(0.37M); 
            Console.WriteLine("Total price of test calls: {0:F2}", price);
        }

        public static void RemoveLongestCall()
        {
            Call longestCall = testGSM.CallHistory.OrderBy(x => x.Duration).ToArray()[testGSM.CallHistory.Count - 1]; 
            testGSM.DeleteCalls(longestCall); 
        }




        static void Main()
        {
            GSMCallHistoryTest.CreateCalltestHistory();

            GSMCallHistoryTest.DisplayCalltestHistory();

            Console.WriteLine(new string('-', 25));

            GSMCallHistoryTest.CalculateAndPrintTestcallsPrice();

            GSMCallHistoryTest.RemoveLongestCall();

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("{0}\n{1}", "Price after the longest call is removed: ", new string('-', 25));

            GSMCallHistoryTest.CalculateAndPrintTestcallsPrice();

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("{0}\n{1}", "Call history after the longest call is removed: ", new string('-', 25));

            GSMCallHistoryTest.DisplayCalltestHistory();

            Console.WriteLine(new string('-', 25));

            GSMCallHistoryTest.testGSM.ClearHistory();

            Console.WriteLine("{0}\n{1}", "Call history list is cleared...", new string('-', 25));

            GSMCallHistoryTest.DisplayCalltestHistory();
        }
    }

}