namespace Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Matrix;

    public class TestMatrix
    {
        static void Main()
        {
            int row = 4, col = 5;
            var matrix1 = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix1[r, c] = 1;
                }
            }

            row = 5;
            col = 3;
            var matrix2 = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix2[r, c] = 1;
                }
            }

            Console.WriteLine(matrix1);
            Console.WriteLine(matrix2);

            //Console.WriteLine(matrix1 + matrix2);
            //Console.WriteLine(matrix1 - matrix2);
            Console.WriteLine(matrix1 * matrix2);
            }
        }
    }
