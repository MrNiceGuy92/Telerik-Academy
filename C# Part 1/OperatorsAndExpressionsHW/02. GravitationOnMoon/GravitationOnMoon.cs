//Problem 2. Gravitation on the Moon
//
//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.


using System;

namespace GravitationOnMoon
{
    class GravitationOnMoon
    {
        static void Main()
        {
            Console.Write("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());

            double moonWeightCoeff = (double)17/100;
            double moonWeight = moonWeightCoeff * weight;

            Console.WriteLine("Your moonweight is: {0}", moonWeight);
        }
    }
}
