namespace TriangleSurface
{

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4. Triangle surface

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

    class TriangleSurface
    {
        static double area; //global variables used in code that follows
        static int sideA, sideB, sideC, altitude;

        static void Main()
        {
            Console.WriteLine("1. AreaBySideAndAltitude \n2. AreaByThreeSides \n3. AreaByTwoSidesAndAngle");
            Console.WriteLine();
            Console.Write("Choose a way to calculate area (either 1,2 or 3): ");
            int choice = int.Parse(Console.ReadLine());

            while (choice < 1 || choice > 3)
            {
                Console.Write("Choose 1, 2 or 3: ");
                choice = int.Parse(Console.ReadLine());
            }

            if (choice == 1)
            {
                Console.Write("Side: ");
                sideA = int.Parse(Console.ReadLine());
                Console.Write("Altitude: ");
                altitude = int.Parse(Console.ReadLine());
                Console.Write("The area is: {0}", AreaBySideAndAltitude(sideA, altitude));
                Console.WriteLine(); 
            }
            else if (choice == 2)
            {
                Console.Write("Side A: ");
                sideA = int.Parse(Console.ReadLine());
                Console.Write("Side B: ");
                sideB = int.Parse(Console.ReadLine());
                Console.Write("Side C: ");
                sideC = int.Parse(Console.ReadLine());
                Console.Write("The area is: {0}", AreaByThreeSides(sideA, sideB, sideC));
                Console.WriteLine();
            }
            else //(choice == 3)
            {
                Console.Write("Side A: ");
                sideA = int.Parse(Console.ReadLine());
                Console.Write("Side B: ");
                sideB = int.Parse(Console.ReadLine());
                Console.Write("Angle: ");
                double angle = double.Parse(Console.ReadLine());
                Console.Write("The area is: {0}", AreaByTwoSidesAndAngle(sideA, sideB, angle));
                Console.WriteLine();
            }
        }

        static double AreaBySideAndAltitude(int side, int altitude)
        {
            area = 0.5 * side * altitude;
            return area;
        }

        static double AreaByThreeSides(int sideA, int sideB, int sideC)
        {
            double halfParameter = 0.5 * (sideA + sideB + sideC);

            //Heron's formula
            area = Math.Sqrt(halfParameter * (halfParameter - sideA) * (halfParameter - sideB) * (halfParameter - sideC));
            return area;
        }

        static double AreaByTwoSidesAndAngle(int sideA, int sideB, double angle)
        {
            area = 0.5 * sideA * sideB * Math.Sin(Math.PI * angle /180.0); //Angle must be in radians
            return area;
        }
    }
}
