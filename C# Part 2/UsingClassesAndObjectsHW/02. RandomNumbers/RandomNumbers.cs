namespace RandomNumbers
{

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 2. Random numbers

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

    class RandomNumbers
    {
        static void Main()
        {
            Random randomNumGenerator = new Random();

            Console.Write("Ten random values in the range [100,200]: ");
            for (int i = 0; i < 10; i++)
            {
                if(i < 9)
                {
                    Console.Write(randomNumGenerator.Next(100,201) + ",");
                }
                else
                {
                    Console.Write(randomNumGenerator.Next(100, 201));
                }
            }
            Console.WriteLine();
        }
    }
}
