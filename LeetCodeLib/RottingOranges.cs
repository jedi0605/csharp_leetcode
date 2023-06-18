using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class RottingOranges
    {
        public static int OrangesRotting(int[][] grid)
        {
            int freshOranges = 0;
            int time = 0;
            Queue<List<int>> q = new Queue<List<int>>();
            List<List<int>> dir = new List<List<int>>() { new List<int> { 1, 0 }, new List<int> { -1, 0 }, new List<int> { 0, 1 }, new List<int> { 0, -1 } };

            // init q and fresh count
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                        freshOranges++;
                    if (grid[i][j] == 2)
                        q.Enqueue(new List<int>() { i, j });
                }
            }

            while (q.Count > 0&& freshOranges > 0)
            {
                int runTimes = q.Count;
                for (int i = 0; i < runTimes; i++)
                {
                    List<int> cur = q.Dequeue();                    
                    // go 4 dir.
                    for (int j = 0; j < 4; j++)
                    {
                        int x = cur[0] + dir[j][0];
                        int y = cur[1] + dir[j][1];
                        if (x >= grid.Length || y >= grid[0].Length || x < 0 || y < 0 || grid[x][y] != 1)
                            continue;
                        grid[x][y] = 2;
                        q.Enqueue(new List<int> { x, y });
                        freshOranges--;
                    }
                }
                time++;
            }
            return freshOranges == 0 ? time : -1;
        }
    }
}