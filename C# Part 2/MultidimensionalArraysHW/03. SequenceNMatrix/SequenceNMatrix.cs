//Problem 3. Sequence n matrix

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceNMatrix
{
    static void Main()
    {
        string[,] matrix = {
                            {"mo", "beep", "beep", "beep"},
                            {"car", "car", "c", "car"},
                            };

        int counter = 1;
        int maxCount = 0;
        int currentRow = 0;
        int currentCol = 0;
        List<string> myList = new List<string>();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if ((col < matrix.GetLength(1) - 1) && (matrix[row, col + 1] == matrix[row, col]))
                {
                    currentCol = col + 1;

                    while ((currentCol < matrix.GetLength(1)) && (matrix[row, currentCol] == matrix[row, col]))
                    {
                        counter++;
                        currentCol++;

                        if (counter > maxCount)
                        {
                            maxCount = counter;
                            myList.Clear();
                            myList.Add(matrix[row, col]);
                        }
                        else if (counter == maxCount)
                        {
                            myList.Add(matrix[row, col]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    currentCol = 0;
                    counter = 1;
                }

                if ((row < matrix.GetLength(0) - 1) && (col < matrix.GetLength(1) - 1) &&
                    (matrix[row + 1, col + 1] == matrix[row, col]))
                {
                    currentCol = col + 1;
                    currentRow = row + 1;

                    while ((currentRow < matrix.GetLength(0)) && (currentCol < matrix.GetLength(1)) &&
                           (matrix[currentRow, currentCol] == matrix[row, col]))
                    {
                        counter++;
                        currentRow++;
                        currentCol++;
                        if (counter > maxCount)
                        {
                            maxCount = counter;
                            myList.Clear();
                            myList.Add(matrix[row, col]);
                        }
                        else if (counter == maxCount)
                        {
                            myList.Add(matrix[row, col]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    currentRow = 0;
                    currentCol = 0;
                    counter = 1;
                }

                if ((row < matrix.GetLength(0) - 1) && (matrix[row + 1, col] == matrix[row, col]))
                {
                    currentRow = row + 1;

                    while ((currentRow < matrix.GetLength(0)) && (matrix[currentRow, col] == matrix[row, col]))
                    {
                        counter++;
                        currentRow++;
                        if (counter > maxCount)
                        {
                            maxCount = counter;
                            myList.Clear();
                            myList.Add(matrix[row, col]);
                        }
                        else if (counter == maxCount)
                        {
                            myList.Add(matrix[row, col]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    currentRow = 0;
                    counter = 1;
                }

                if ((row < matrix.GetLength(0) - 1) && (col > 0) && (matrix[row + 1, col - 1] == matrix[row, col]))
                {
                    currentRow = row + 1;
                    currentCol = col - 1;

                    while ((currentRow < matrix.GetLength(0)) && (currentCol >= 0) &&
                           (matrix[currentRow, currentCol] == matrix[row, col]))
                    {
                        counter++;
                        currentRow++;
                        currentCol--;
                        if (counter > maxCount)
                        {
                            maxCount = counter;
                            myList.Clear();
                            myList.Add(matrix[row, col]);
                        }
                        else if (counter == maxCount)
                        {
                            myList.Add(matrix[row, col]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    currentRow = 0;
                    currentCol = 0;
                    counter = 1;
                }
            }
        }

        Console.Write("The longest sequence: ");

        if (maxCount > 0)
        {
            foreach (string item in myList)
            {
                for (int i = 0; i < maxCount; i++)
                {
                    if (i < maxCount - 1)
                    {
                        Console.Write("{0}, ", item);
                    }
                    else
                    {
                        Console.Write("{0}", item);
                    }
                }
                Console.WriteLine();
            }
        }
        else
        {
            foreach (string item in matrix)
            {
                Console.WriteLine(item);
            }
        }
    }    
}


//Alternative solution
//Console.WriteLine("Enter rows size:");
//        int rows = int.Parse(Console.ReadLine());
//        Console.WriteLine("Enter cols size:");
//        int cols = int.Parse(Console.ReadLine());

//        string[,] stringMatrix = new string[rows,cols];

//        // Fill the matrix by reading from console
//        for (int row = 0; row < stringMatrix.GetLength(0); row++)
//        {
//            for (int col = 0; col < stringMatrix.GetLength(1); col++)
//            {
//                Console.Write("stringMatrix[{0},{1}] = ", row, col);
//                string element = Console.ReadLine();
                
//                stringMatrix[row, col] = element;
//            }
//        }
//        Console.WriteLine();

//        FindLongestSequenceAndPrintMatrix(stringMatrix);
   
//    }
//    private static void FindLongestSequenceAndPrintMatrix(string[,]matrix)
//    {
//        bool onVertical = false;
//        bool onHorizontal = false;
//        bool onDiagonal = false;
//        string bestElement = "";
//        int currentLength = 0;
//        int maxLength = 0;     

//        for (int col = 0; col < matrix.GetLength(0); col++)
//        {
//            // Check horizontally 
//            currentLength = 0;
//            for (int i = 0; i < matrix.GetLength(1) - 1; i++)
//            {
//                if (matrix[col, i] == matrix[col, i + 1])
//                {
//                    currentLength++;
//                }
//                if (currentLength > maxLength)
//                {
//                    maxLength = currentLength;
//                    bestElement = matrix[col, i];   
//                    onHorizontal = true; onVertical = false; onDiagonal = false;
//                }
//            }
//            //Check for verticcaly
//            currentLength = 0;
//            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
//            {
//                if (matrix[i, col] == matrix[i + 1, col])
//                {
//                    currentLength++;
//                }
//                if (currentLength > maxLength)
//                {
//                    maxLength = currentLength;
//                    bestElement = matrix[i, col];
//                    onHorizontal = false; onVertical = true; onDiagonal = false;
//                }
//            }
//            //Check for diagonals
//            currentLength = 0;
//            for (int i = 0, j = 0; (i < matrix.GetLength(0)-1) && (j < matrix.GetLength(1)-1); i++, j++)
//            {
//                if (matrix[ i , j] == matrix[i + 1,j + 1])
//                {
//                    currentLength++;
//                }
//                if (currentLength > maxLength)
//                {
//                    maxLength = currentLength;
//                    bestElement = matrix[i , j];
//                    onHorizontal = false; onVertical = false; onDiagonal = true;
//                }                                    
//            }
//        }
//        // Print the matrix
//        for (int row = 0; row < matrix.GetLength(0); row++)
//        {
//            for (int col = 0; col < matrix.GetLength(1); col++)
//            {
//                Console.Write("{0,-4}", matrix[row, col]);
//                Console.ForegroundColor = ConsoleColor.Gray;
//            }
//            Console.WriteLine("\n");
//        }

//        // Print the result
//        Console.Write("The maximal sequence in the matrix is :\n");
//        if (onHorizontal)
//        {
//            for (int i = 0; i < maxLength + 1; i++)
//            {
//                Console.Write("{0}, ", bestElement);
//            }
//            Console.WriteLine("from left to right on horizontal");
   
//        }
//        if (onVertical)
//        {
//            for (int i = 0; i < maxLength + 1; i++)
//            {
//                Console.Write("{0}, ", bestElement);
//            }
//            Console.WriteLine("from up to down on vertical");   
//        }
//        if (onDiagonal)
//        {
//            for (int i = 0; i < maxLength + 1; i++)
//            {
//                Console.Write("{0}, ", bestElement);
//            }
//            Console.WriteLine("on diagonal");   
//        } 