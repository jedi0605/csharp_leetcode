using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class InsertInterval
    {
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> res = new List<int[]>();

            foreach (var interval in intervals)
            {
                if (interval[1] < newInterval[0])
                {
                    res.Add(interval);
                }
                else if (interval[0] > newInterval[1])
                {
                    res.Add(newInterval);
                    newInterval = interval; // shift current interval
                }
                else
                {
                    newInterval[0] = Math.Min(newInterval[0], interval[0]);
                    newInterval[1] = Math.Max(newInterval[1], interval[1]);
                }
            }
            res.Add(newInterval); // Add Last one.
            return res.ToArray();
        }
    }
}