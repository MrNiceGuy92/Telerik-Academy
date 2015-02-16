//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSequence
{
    static void Main()
    {
        //Hardcoded example from problem
        string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1";

        int[] numbers = input
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n)).ToArray();

        //Inputing elements of array by hand

        //Console.Write("Length of array: ");
        //int length = int.Parse(Console.ReadLine());

        //int[] numbers = new int[length];

        //Console.WriteLine();
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.Write("numArray[{0}]: ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}

        int currentPosition = numbers[0];
        int maxCount = 0;
        int currentCount = 1;
        int bestNumber = 0;

        if (numbers.Length == 1)
        {
            Console.Write("The maximum sequence is: ");
            Console.WriteLine(numbers[0]);
            Console.WriteLine();
        }
        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != currentPosition)
                {
                    currentCount = 1;
                    currentPosition = numbers[i];
                }
                else
                {
                    currentCount++;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    bestNumber = currentPosition;
                }
            }

            Console.Write("Maximum sequence of equal elements in array: ");
            for (int i = 0; i < maxCount; i++)
            {
                if (i != maxCount - 1)
                {
                    Console.Write(bestNumber + ", ");
                }
                else
                {
                    Console.Write(bestNumber);
                }
            }
            Console.WriteLine();
        }
    }
}

//Alternative solution (Evlogi)

// if you want to test with other string uncoment
        //string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1";
        //string input = "2, 1, 1, 1, 2, 3, 3, 2, 2, 2, 1";
        //string input = "2, 1, 1, 1, 1, 2, 3, 3, 2, 2, 2, 1";
        //string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 2, 2, 1";
        //string input = "2, 2, 2, 2, 2, 2, 1, 1, 2, 3, 3, 2, 2, 2, 1";
        //string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1";
        //string input = "1, 2, 3, 4, 5, 6";

    //    string[] numsStr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
    //    int[] nums = new int[numsStr.Length];
    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        nums[i] = int.Parse(numsStr[i]);
    //    }

    //    int[] numbers = input
    //        .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
    //        .Select(n => int.Parse(n)).ToArray();

    //    int[] hardcodedNums = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

    //    int currentNum, maxNum = nums[0];
    //    int currentCount, maxCount = 0;
    //    for (int i = 0; i < nums.Length; )
    //    {
    //        currentNum = nums[i];
    //        currentCount = 0;
    //        for (; i < nums.Length; i++)
    //        {
    //            if (currentNum != nums[i])
    //            {
    //                break;
    //            }
    //            currentCount++;
    //        }
    //        if (maxCount <= currentCount)
    //        {
    //            maxCount = currentCount;
    //            maxNum = currentNum;
    //        }
    //    }
    //    for (int i = 0; i < maxCount; i++)
    //    {
    //        Console.Write(maxNum);
    //        if (i != maxCount - 1)
    //        {
    //            Console.Write(", ");
    //        }
    //    }
    //    Console.WriteLine();
    //}

//// Alternative solution 2: using LINQ
//// Find the largest sequel using LINQ (SQL like addition to .Net, used for querying objects etc.)
//int[] largestSequence = array.Select((n, i) => new { Value = n, Index = i })
//                .OrderBy(s => s.Value)
//                .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
//                .GroupBy(s => new { s.Value, s.Diff })
//                .OrderByDescending(g => g.Count())
//                .First()
//                .Select(f => f.Value)
//                .ToArray();

//foreach (int digit in largestSequence)
//{
//    Console.Write(digit + " ");
//}
//Console.WriteLine(); 