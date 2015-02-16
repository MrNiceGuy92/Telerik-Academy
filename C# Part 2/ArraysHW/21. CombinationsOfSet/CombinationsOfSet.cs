//Problem 21.* Combinations of set

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CombinationsOfSet
{
    static void Main()
    {
        int n = 5; //Console.ReadLine();
        int k = 2; //Console.ReadLine();

        //Fill up array
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }

        Combinations(arr, new int[k], 0, 0);
    }

    private static void Combinations(int[] nums, int[] arr, int index, int currentIndex)
    {
        //Bottom of recursion
        if (index == arr.Length)
        {
            Console.WriteLine(string.Join(", ", arr));
            return;
        }

        //Update of recursion
        for (int i = currentIndex; i < nums.Length; i++)
        {
            arr[index] = nums[i];
            Combinations(nums, arr, index + 1, currentIndex + 1);
        }
    }
}

