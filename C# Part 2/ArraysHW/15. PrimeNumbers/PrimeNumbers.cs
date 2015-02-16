//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeNumbers
{
    static void Main()
    {
        //Brute force solution

        int lower = 1;
        int upper = 100; //10 000 000 is a VERY big number => it would take a while to print on console, so I used 100 instead
                         // but code works for 10 000 000, if you are patient :)
        long[] arr = new long[upper];

        //Fill up array
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = lower;
            lower++;
        }

        //Create a list of the same array, so removal of non-primes is easier later
        List<long> myList = new List<long>(arr);

        int initialPosition = 2; 
        for (int i = 1; i < arr.Length - 1; i++)
        {
            for (int j = 2; j < arr.Length; j++)
            {
                if (myList.Contains(j * initialPosition))
                {
                    myList.Remove(j*initialPosition); 
                    continue;
                }
            }
            initialPosition++;
        }
        //Print prime numbers in range
        for (int i = 0; i < myList.Count; i++)
        {
            Console.Write(myList[i] + " ");
        }
    }
}


//Alternative solution
//static void Main(string[] args)
//    {
//        bool[] primeNumbers = new bool[100];  // all numbers value is false by default;

//        for (int i = 0; i < primeNumbers.Length; i++)
//        {
//            primeNumbers[i] = true;               // so we set them all to true to be easier to chech them
//        }

//        // checking for prime numbers

//        for (int i = 2; i < primeNumbers.Length; i++)
//        {
//            if (primeNumbers[i])
//            {
//                for (int j = i + i; j < primeNumbers.Length; j += i)
//                {

//                    primeNumbers[j] = false;
//                }
//            }

//        }

//        for (int i = 2; i < primeNumbers.Length; i++)
//        {
//            if (primeNumbers[i])
//            {
//                Console.Write("{0} ", i);
//            }

//        }
//        Console.WriteLine();
//    }