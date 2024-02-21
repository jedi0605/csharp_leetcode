using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class InsertInterval2
    {
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> res = new List<int[]>();
            List<int[]> tmp = new List<int[]>(intervals);

            for (int i = 0; i < tmp.Count; i++)
            {
                if (newInterval[1] < intervals[i][0]) // newInterval is before the current intervals
                {
                    res.Add(newInterval);
                    res.AddRange(tmp.GetRange(i, tmp.Count - i));
                    return res.ToArray();
                }
                else if (newInterval[0] > intervals[i][1])
                    res.Add(intervals[i]);
                else
                {
                    newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                    newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
                }
            }

            res.Add(newInterval);
            return res.ToArray();
        }
    }
}