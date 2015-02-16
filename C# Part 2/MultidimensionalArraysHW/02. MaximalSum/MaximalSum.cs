//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main()
    {
        //Hardcoded matrix
        int[,] matrix = {
                            {0,2,4,0,9,5},
                            {7,1,3,3,2,1},
                            {1,3,9,8,5,6},
                            {4,6,7,9,1,0},
                            {0,100,500,100,0,1}
                        };

        //Input elements of array by hand

        //Console.Write("Number of rows: ");
        //int rows = int.Parse(Console.ReadLine());

        //Console.Write("Number of columns: ");
        //int columns = int.Parse(Console.ReadLine());

        //int[,] matrix = new int[rows, columns];

        //for (int row = 0; row < rows; row++)
        //{
        //    for (int column = 0; column < columns; column++)
        //    {
        //        Console.Write("matrix[{0},{1}]= ", row, column);
        //        matrix[row, column] = int.Parse(Console.ReadLine());
        //    }
        //}

        long bestSum = long.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        int height = 3;
        int width = 3;

        for (int r = 0; r < matrix.GetLength(0) - height + 1; r++)
        {
            for (int c = 0; c < matrix.GetLength(1) - width + 1; c++)
            {
                long sum = 0;
                for (int platformRow = r; platformRow < r + height; platformRow++)
                {
                    for (int platformCol = c; platformCol < c + width; platformCol++)
                    {
                        sum += matrix[platformRow, platformCol];
                    }
                }

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = r;
                    bestCol = c;
                }
            }
        }

        //Printing the result
        Console.WriteLine("The best platform is:");
        for (int platFormRow = bestRow; platFormRow < bestRow + height; platFormRow++)
        {
            for (int platFormCol = bestCol; platFormCol < bestCol + width; platFormCol++)
            {
                Console.Write(matrix[platFormRow, platFormCol] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }
}

