using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SpiralMatrix2
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> res = new List<int>();
            int left = 0; int top = 0;
            int right = matrix[0].Length;
            int botton = matrix.Length;

            while (top < botton && left < right)
            {
                // left to right
                for (int i = left; i < right; i++)
                    res.Add(matrix[top][i]);
                top++;
                // top to botton
                for (int i = top; i < botton; i++)
                    res.Add(matrix[i][right - 1]);
                right--;

                //todo [1,2,3,4] case and [1|2|3|4]
                if (left >= right || top >= botton)
                    break;

                // right to left
                for (int i = right - 1; i >= left; i--)
                    res.Add(matrix[botton - 1][i]);
                botton--;

                // botton to top
                for (int i = botton - 1; i >= top; i--)
                    res.Add(matrix[i][left]);
                left++;
            }
            return res;
        }
    }
}