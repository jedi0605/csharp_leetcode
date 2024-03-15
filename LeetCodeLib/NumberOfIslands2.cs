using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class NumberOfIslands2
    {
        public HashSet<(int, int)> maps = new HashSet<(int, int)>();
        public int row = 0;
        public int col = 0;
        public int NumIslands(char[][] grid)
        {
            if (grid == null)
                return 0;
            this.row = grid.Count();
            this.col = grid[0].Count();
            int count = 0;

            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    if (maps.Contains((i, j)) == false && grid[i][j] == '1')
                    {
                        bfsHelper(i, j, grid);
                        count++;
                    }
                }
            }

            return count;
        }

        private void bfsHelper(int i, int j, char[][] grid)
        {
            List<(int, int)> dir = new List<(int, int)>() { (1, 0), (-1, 0), (0, 1), (0, -1) };
            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue((i, j));
            while (q.Count > 0)
            {
                (int, int) curr = q.Dequeue();
                foreach (var item in dir)
                {
                    int subR = curr.Item1 + item.Item1;
                    int subC = curr.Item2 + item.Item2;
                    if (subR >= 0 && subC >= 0 && subR < this.row && subC < this.col &&
                        maps.Contains((subR, subC)) == false &&
                          grid[subR][subC] == '1')
                    {
                        q.Enqueue((subR, subC));
                        maps.Add((subR, subC));
                    }
                }
            }
        }
    }
}