using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class NumberOfIslands
    {
        public static int NumIslands(char[][] grid)
        {
            if (grid == null)
                return 0;
            int row = grid.Count();
            int col = grid[0].Count();
            int count = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        _DfsHelper(grid, i, j);
                    }
                }
            }
            return count;
        }

        private static void _DfsHelper(char[][] grid, int i, int j)
        {
            if (i < 0 ||
                j < 0 ||
                i >= grid.Count() ||
                j >= grid[0].Count() ||
                grid[i][j] != '1') // Terminate condition.
                return;
            grid[i][j] = '*';
            _DfsHelper(grid, i, j + 1);
            _DfsHelper(grid, i, j - 1);
            _DfsHelper(grid, i - 1, j);
            _DfsHelper(grid, i + 1, j);
        }
    }
}