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
                            {"ha", "fifi", "ho", "hi"},
                            {"fo", "ha", "hi", "xx"},
                            {"xxx", "ho", "ha", "xx"}
                            };

        int horizCounter = 1;
        int vertCounter = 1, diagonalCounter = 1;
        int maxVertCounter = 1, maxHorizCounter = 1, maxDiagCounter =1;
        string horizSequence = "", vertSequence = "", diagSequence = "";

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                if (matrix[row,col] == matrix[row,col -1])
                {
                    horizCounter++;
                }
                if (matrix[row,col - 1] == matrix[row + 1, col -1])
                {
                    vertCounter++;
                }
                if ((row == col - 1) && (matrix[row,col] == matrix[row + 1, col + 1]))
                {
                    diagonalCounter++;
                }
                if (diagonalCounter > maxDiagCounter)
                {
                    maxDiagCounter = diagonalCounter;
                    diagSequence += matrix[row, col]; 
                }
                if (horizCounter > maxHorizCounter)
                {
                    maxHorizCounter = horizCounter;
                    horizSequence += matrix[row, col];
                }
                if (vertCounter > maxVertCounter)
                {
                    maxVertCounter = vertCounter;
                    vertSequence += matrix[row, col - 1];
                }
                
            }
        }
        Console.WriteLine(diagSequence);
    }
}

