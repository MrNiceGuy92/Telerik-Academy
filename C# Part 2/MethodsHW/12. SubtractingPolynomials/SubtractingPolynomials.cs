//Problem 12. Subtracting polynomials

//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class SubtractingPolynomials
{
    static void Main()
    {
        Console.Write("Degree (highest power) of first polynomial: ");
        int firstDegree = int.Parse(Console.ReadLine());
        Console.Write("Degree (highest power) of second polynomial: ");
        int secondDegree = int.Parse(Console.ReadLine());

        Console.WriteLine();
        int[] firstPolynomial = new int[firstDegree + 1]; // Example: 6x^3 + 5x^2 + x + 5 has four coefficients (6,5,1,5), but is of order 3  
        Console.WriteLine("Coefficients of  first polynomial:");
        for (int i = 0; i < firstDegree + 1; i++)
        {
            Console.Write("firstPolynomial[{0}]= ", i);
            firstPolynomial[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        int[] secondPolynomial = new int[secondDegree + 1]; // Example: 3x^3 + 7x^2 + 1 has four coefficients (3,7,0,1), but is of order 3 
        Console.WriteLine("Coefficients of second polynomial:");
        for (int i = 0; i < secondDegree + 1; i++)
        {
            Console.Write("secondPolynomial[{0}]= ", i);
            secondPolynomial[i] = int.Parse(Console.ReadLine());
        }

        SubtractionOfPolynomials(firstPolynomial, secondPolynomial);
    }

    static void SubtractionOfPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        if (firstPolynomial.Length >= secondPolynomial.Length)
        {
            for (int i = 0; i < secondPolynomial.Length; i++)
            {
                if (secondPolynomial[i] < 0 && firstPolynomial[i] < 0)
                {
                    firstPolynomial[i] = secondPolynomial[i] + firstPolynomial[i];
                }
                else if (secondPolynomial[i] < 0 && firstPolynomial[i] > secondPolynomial[i])
                {
                    firstPolynomial[i] = secondPolynomial[i] + firstPolynomial[i];
                }
                else if (secondPolynomial[i] < 0 && firstPolynomial[i] < secondPolynomial[i])
                {
                    firstPolynomial[i] = -(secondPolynomial[i] - firstPolynomial[i]);
                }
                else if (firstPolynomial[i] < 0 && secondPolynomial[i] > firstPolynomial[i])
                {
                    firstPolynomial[i] = secondPolynomial[i] + firstPolynomial[i];
                }
                else if (firstPolynomial[i] < 0 && firstPolynomial[i] > secondPolynomial[i])
                {
                    firstPolynomial[i] = -(firstPolynomial[i] - secondPolynomial[i]);
                }
                else
	            {
                    firstPolynomial[i] = firstPolynomial[i] - secondPolynomial[i];
	            }
                
            }
            Console.Write("The coefficients of the polynomials are: ");
            foreach (int num in firstPolynomial)
            {
                Console.Write(num + ",");
            }
            Console.WriteLine();
        }
        else if (firstPolynomial.Length < secondPolynomial.Length)
        {
            for (int i = 0; i < firstPolynomial.Length; i++)
            {
                if (firstPolynomial[i] < 0 && secondPolynomial[i] < 0)
                {
                    secondPolynomial[i] = -(firstPolynomial[i] + secondPolynomial[i]);
                }
                else if (firstPolynomial[i] < 0 && secondPolynomial[i] > firstPolynomial[i])
                {
                    secondPolynomial[i] = firstPolynomial[i] + secondPolynomial[i];
                }
                else if (firstPolynomial[i] < 0 && secondPolynomial[i] < firstPolynomial[i])
                {
                    secondPolynomial[i] = -(firstPolynomial[i] - secondPolynomial[i]);
                }
                else if (secondPolynomial[i] < 0 && firstPolynomial[i] > secondPolynomial[i])
                {
                    secondPolynomial[i] = firstPolynomial[i] + secondPolynomial[i];
                }
                else if (secondPolynomial[i] < 0 && secondPolynomial[i] > firstPolynomial[i])
                {
                    secondPolynomial[i] = -(secondPolynomial[i] - firstPolynomial[i]);
                }
                else
                {
                    secondPolynomial[i] = secondPolynomial[i] - firstPolynomial[i];
                }
                
            }
            Console.Write("The coefficients of the polynomials are: ");
            foreach (int num in secondPolynomial)
            {
                Console.Write(num + ",");
            }
            Console.WriteLine();
        }
    }
}

//No idea how to do polynomial multipication :) Help :)