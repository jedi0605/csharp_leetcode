using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class RotateImage
    {
        public static void Rotate(int[][] matrix)
        {
            int l = 0;
            int r = matrix.Length - 1;

            while (l < r)
            {
                int top = l;
                int botton = r;

                for (int i = 0; i < r - l; i++)
                {
                    // save top left = tmp
                    int topLeft = matrix[top][l + i];

                    // botton left to top left
                    matrix[top][l + i] = matrix[botton - i][l];

                    // botton right to botton left
                    matrix[botton - i][l] = matrix[botton][r - i];

                    // top right to botton right
                    matrix[botton][r - i] = matrix[top + i][r];

                    // top left to top right
                    matrix[top + i][r] = topLeft;
                }

                r--;
                l++;
            }
        }
    }
}