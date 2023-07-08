using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SpiralMatrixReview
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> res = new List<int>();
            int endCol = matrix[0].Length - 1;
            int endRow = matrix.Length - 1;
            int startRow = 0;
            int startCol = 0;
            // Clock wise approch
            while (startRow <= endRow && startCol <= endCol)
            {
                for (int i = startCol; i <= endCol; i++)
                {
                    System.Diagnostics.Debug.Write(matrix[startCol][i]);
                    res.Add(matrix[startCol][i]);
                }
                startRow++;

                for (int i = startRow; i <= endRow; i++)
                {
                    System.Diagnostics.Debug.Write(matrix[i][endCol]);
                    res.Add(matrix[i][endCol]);
                }
                endCol--;

                if (startRow <= endRow)
                {
                    for (int i = endCol; i >= startCol; i--)
                    {
                        System.Diagnostics.Debug.Write(matrix[endRow][i]);
                        res.Add(matrix[endRow][i]);
                    }
                }
                endRow--;

                if (startCol <= endCol)
                {
                    for (int i = endRow; i >= startRow; i--)
                    {
                        System.Diagnostics.Debug.Write(matrix[i][startCol]);
                        res.Add(matrix[i][startCol]);
                    }
                }
                startCol++;
            }
            return res;

        }
    }
}