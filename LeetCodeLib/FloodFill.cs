using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Explain.
    /// image = [[1,1,1],[1,1,0],[1,0,1]], sr = 1, sc = 1, color = 2
    /// [1,1,1],
    /// [1,1,0],
    /// [1,0,1]
    /// Change to 
    /// [1,2,1],
    /// [2,2,0],
    /// [1,0,1]
    /// Change to 
    /// [2,2,2],
    /// [2,2,0],
    /// [2,0,1]
    /// 
    /// Hint DFS, graph
    /// 
    /// </summary>
    public static class FloodFill
    {
        public static int[][] Fill(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] == color)
                return image;
            else
                _fill(image, sr, sc, image[sr][sc], color);
            return image;
        }

        private static void _fill(int[][] image, int sr, int sc, int orgColor, int newColor)
        {
            // Check out-bound
            if (sr < 0 || sc < 0 || sr > image.Length - 1 || sc > image[0].Length - 1)
                return;

            if (image[sr][sc] != orgColor)
                return;

            image[sr][sc] = newColor;
            Print(image);
            _fill(image, sr - 1, sc, orgColor, newColor);
            _fill(image, sr + 1, sc, orgColor, newColor);
            _fill(image, sr, sc - 1, orgColor, newColor);
            _fill(image, sr, sc + 1, orgColor, newColor);
        }

        public static void Print(int[][] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    System.Diagnostics.Debug.Write(myArray[i][j] + " ");
                }
                System.Diagnostics.Debug.Write("\n");
            }
            System.Diagnostics.Debug.Write("\n");
        }

        public static bool FloodEquals(int[][] myArray, int[][] array2)
        {

            try
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    for (int j = 0; j < myArray[i].Length; j++)
                    {
                        if (myArray[i][j] != array2[i][j])
                            return false;
                    }
                }
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }

    }
}