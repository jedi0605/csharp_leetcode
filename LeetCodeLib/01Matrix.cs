using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class ZeroOneMatrix
    {
        public static int[][] UpdateMatrix(int[][] mat)
        {
            int row = mat.Length;
            int col = mat[0].Length;
            if (row == 1 && col == 1)
            {
                return mat;
            }

            int[][] res = new int[row][];
            int maxDis = row + col;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (mat[i][j] == 0)
                        continue;
                    res[i][j] = maxDis;
                    if (i > 0)
                        res[i][j] = Math.Min(res[i][j], res[i - 1][j] + 1);
                    if (j > 0)
                        res[i][j] = Math.Min(res[i][j], res[i][j] - 1 + 1);
                }
            }
            return res;
        }

        public static int[][] UpdateMatrixBFS(int[][] mat)
        {
            int row = mat.Length;
            int col = mat[0].Length;
            if (row == 1 && col == 1)
            {
                return mat;
            }

            // 4 diraction
            List<(int, int)> dirs = new List<(int, int)> { (-1, 0), (1, 0), (0, 1), (0, -1) };
            Queue<(int, int)> queue = new Queue<(int, int)>(); // for store
            HashSet<(int, int)> visted = new System.Collections.Generic.HashSet<(int, int)>(); // tracking exist

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        queue.Enqueue((i, j));
                        visted.Add((i, j));
                    }
                }
            }

            while (queue.Count != 0)
            {
                var q = queue.Dequeue();
                var r = q.Item1;
                var c = q.Item2;
                System.Diagnostics.Debug.WriteLine(q);

                foreach (var item in dirs)
                {
                    //System.Diagnostics.Debug.WriteLine(item);
                    int nX = r + item.Item1; // calculate the edge
                    int nY = c + item.Item2;
                    // chech not out of range and not traveled
                    if (nX >= 0 && nY >= 0 && nX < row && nY < col && visted.Contains((nX, nY)) == false) 
                    {
                        mat[nX][nY] = mat[r][c] + 1;
                        System.Diagnostics.Debug.WriteLine(nX + " " + nY + " " + (mat[r][c] + 1));
                        queue.Enqueue((nX, nY));
                        visted.Add((nX, nY));
                    }
                }
            }
            return mat;
        }
    }
}