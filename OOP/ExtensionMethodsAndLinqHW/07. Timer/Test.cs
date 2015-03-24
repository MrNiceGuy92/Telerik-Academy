namespace _07.Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Test
    {
        static void Main()
        {
            Timer timer = new Timer(5);

            timer.SomeMethods += FirstTestMethod;
            timer.SomeMethods += SecondTestMethod;

            timer.ExecuteMethods();
        }

        public static void FirstTestMethod()
        {
            Console.WriteLine("Method 1 will be executed after some milliseconds.");
        }

        public static void SecondTestMethod()
        {
            Console.WriteLine("Method 2 will be executed after some milliseconds.");
        }
    }
}
