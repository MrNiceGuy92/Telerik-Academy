//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Length of first char array: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Length of second char array: ");
        int N = int.Parse(Console.ReadLine());

        char[] firstArray = new char[M];
        char[] secondArray = new char[N];

        int counter = 0;
        bool firstArrayFirst = false;
        bool secondArrayFirst = false;

        Console.WriteLine(new string('-', 20));

        //Reading array elements from console
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("FirstArray[{0}]: ", i);
            firstArray[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("SecondArray[{0}]: ", i);
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        //Checking equality
        if (M >= N)
        {
            for (int i = 0; i < secondArray.Length; i++) //Top boundary is the length of the smaller array
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    firstArrayFirst = true; //If element of second array is larger => first array is in front
                }
                else //(secondArray[i] < firstArray[i])
                {
                    secondArrayFirst = true;
                }
            }
        }
        else if (N > M)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    secondArrayFirst = true;
                }
                else //(secondArray[i] > firstArray[i])
                {
                    firstArrayFirst = true;
                }
            }
        }

        Console.WriteLine(new string('-', 20));
        //Code distinguishes between uppercase and lowercase letters, uppercase being in front in the ASCII table.

        if (counter == M && M == N)
        {
            Console.WriteLine("The arrays are the same.");
        }
        else if (counter == M && M < N)
        {
            Console.WriteLine("The firstArray is smaller and first in lexicographical order.");
        }
        else if (counter == N && M > N)
        {
            Console.WriteLine("The secondArray is smaller and first in lexicographical order.");
        }
        else if (firstArrayFirst)
        {
            Console.WriteLine("FirstArray is first in lexicographical order.");
        }
        else if (secondArrayFirst)
        {
            Console.WriteLine("SecondArray is first in lexicographical order.");
        }
    }
}

// ALTERNATIVE WAY (Evlogi)

// read first array
//Console.Write("Enter first word: ");
//char[] firstWord = Console.ReadLine().ToCharArray();

// read second array
//Console.Write("Enter second word: ");
//char[] secondWord = Console.ReadLine().ToCharArray();

//string lexicographicallyFirst = string.Join("", firstWord);
//int length = Math.Min(firstWord.Length, secondWord.Length);
//for (int i = 0; i < length; i++)
//{
//    if (firstWord[i] > secondWord[i])
//    {
//        lexicographicallyFirst = string.Join("", secondWord);
//        break;
//    }
//}

//Console.WriteLine("Lexicographically first is: {0}", lexicographicallyFirst);

