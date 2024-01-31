using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SetMatrixZeros
    {
        public static void SetZeroes(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            bool[] colsCheck = new bool[cols];
            bool[] rowsCheck = new bool[rows];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[r][c] == 0)
                    {
                        colsCheck[c] = true;
                        rowsCheck[r] = true;
                    }
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (colsCheck[c] == true || rowsCheck[r] == true)
                        matrix[r][c] = 0;
                }
            }
        }

        public static void SetMatrixZeros2(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            bool rowsZero = false;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[r][c] == 0)
                    {
                        matrix[0][c] = 0;
                        if (r == 0)
                            rowsZero = true;
                        else
                            matrix[r][0] = 0;
                    }
                }
            }

            
            for (int r = 1; r < rows; r++)
            {
                for (int c = 1; c < cols; c++)
                {
                    if(matrix[0][c]== 0 || matrix[r][0]==0)
                        matrix[r][c] = 0;
                }
            }
            // Check rows[0] will be zero
            if(matrix[0][0] == 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    matrix[i][0] = 0;
                }
            }

            if(rowsZero)
            {
                for (int i = 0; i < cols; i++)
                {
                    matrix[0][i] = 0;
                }
            }
        }
    }
}