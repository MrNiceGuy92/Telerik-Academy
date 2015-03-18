namespace Tests
{
    using System;
    using MobilePhoneData;

    public class GSMTest
    {
        public static void Main()
        {
            // Each phone below uses different GSM constructor
            GSM[] someGSMs = 
                {
                    new GSM("HTC", "HTC Corporation", "Someone1", 450.45m,
                             new Battery("Duracell", BatteryType.LiLon),
                             new Display(2.7, 14)),
                    new GSM("Nokia Lumia", "Microsoft Corporation", "Someone2", 515.99m,
                             new Battery("Toshiba", 3.5, 4.5, BatteryType.NiCd),
                             new Display(4.5, 12)),
                    new GSM("Sony", "Sony Corporation", "Someone3", 600),
                    GSM.IPhone4S,
                };

            foreach (var phones in someGSMs)
            {
                Console.WriteLine(phones);
                Console.WriteLine();
            }

            // Battery[] someBatteries = {
            //                              new Battery("Duracell", 5, 4, BatteryType.LiLon),
            //                              new Battery("Toshiba", BatteryType.NiCd),
            //                          };

            // foreach (var batteries in someBatteries)
            // {
            //    Console.WriteLine(batteries);
            // }

            // Display[] someDisplays = {
            //                             new Display(), //default values
            //                             new Display(5.5, 23),
            //                         };

            // foreach (var displays in someDisplays)
            // {
            //    Console.WriteLine(displays);
            // }
        }
    }
}