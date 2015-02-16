//Problem 11. Adding polynomials

//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class AddingPolynomials
{
    static void Main()
    {
        Console.Write("Degree (highest power) of first polynomial: ");
        int firstDegree = int.Parse(Console.ReadLine());
        Console.Write("Degree (highest power) of second polynomial: ");
        int secondDegree = int.Parse(Console.ReadLine());

        Console.WriteLine();
        int[] firstPolynomial = new int[firstDegree + 1]; // Example: 6x^3 + 5x^2 + x + 5 has four coefficients (6,5,1,5), but is of order 3  
        Console.WriteLine("Coefficients of  first polynomial: ");
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

        Console.WriteLine();
        AdditionOfPolynomials(firstPolynomial, secondPolynomial);
    }

    static void AdditionOfPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        if (firstPolynomial.Length >= secondPolynomial.Length)
        {
            for (int i = 0; i < secondPolynomial.Length; i++)
            {
                firstPolynomial[i] = firstPolynomial[i] + secondPolynomial[i];
            }
            Console.Write("The coefficients of the polynomials are: ");
            foreach  (int num in firstPolynomial)
            {
                Console.Write(num + ",");
            }
            Console.WriteLine();
        }
        else if (firstPolynomial.Length < secondPolynomial.Length)
        {
            for (int i = 0; i < firstPolynomial.Length; i++)
            {
                secondPolynomial[i] = firstPolynomial[i] + secondPolynomial[i];
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
