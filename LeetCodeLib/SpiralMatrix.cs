using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SpiralMatrix
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> result = new List<int>();
            int totalMatrix = GetTotalCount(matrix);

            int rowBegin = 0;
            int rowEnd = matrix.Length - 1;
            int colBegin = 0;
            int colEnd = matrix[0].Length - 1;



            while (rowBegin <= rowEnd && colBegin <= colEnd)
            {
                // --->
                for (int i = colBegin; i <= colEnd; i++)
                {
                    result.Add(matrix[rowBegin][i]);
                    System.Diagnostics.Debug.WriteLine(matrix[rowBegin][i]);
                }
                rowBegin++;

                // ||| down
                for (int i = rowBegin; i <= rowEnd; i++)
                {
                    result.Add(matrix[i][colEnd]);
                    System.Diagnostics.Debug.WriteLine(matrix[i][colEnd]);
                }
                colEnd--;

                if (rowBegin <= rowEnd) // in case it's [1,1,1] array
                {
                    for (int i = colEnd; i >= colBegin; i--)
                    {
                        result.Add(matrix[rowEnd][i]);
                        System.Diagnostics.Debug.WriteLine(matrix[rowEnd][i]);
                    }
                }
                rowEnd--;

                if (colBegin <= colEnd) // in case it's [1,1,1] array
                {
                    for (int i = rowEnd; i >= rowBegin; i--)
                    {
                        result.Add(matrix[i][colBegin]);
                        System.Diagnostics.Debug.WriteLine(matrix[i][colBegin]);
                    }
                }
                colBegin++;
            }
            return result;
        }

        private static int GetTotalCount(int[][] matrix)
        {
            int totalCount = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                totalCount += matrix[i].Length;
            }
            return totalCount;
        }
    }
}