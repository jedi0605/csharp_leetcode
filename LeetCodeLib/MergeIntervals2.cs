using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class MergeIntervals2
    {
        public static int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 1) return intervals;
            List<List<int>> res = new List<List<int>>();
            List<List<int>> intervalList = intervals.Select(x => x.ToList()).ToList();
            intervalList = intervalList.OrderBy(x => x[0]).ToList();

            res.Add(intervalList[0]);

            for (int i = 1; i < intervalList.Count; i++)
            {
                int start = intervalList[i][0];
                int end = intervalList[i][1];
                int lastEnd = res.Last()[1];

                if (lastEnd >= start)
                    res.Last()[1] = Math.Max(end, lastEnd); //in case [1, 5] [2, 4], need max to get the end valuse                
                else
                    res.Add(new List<int>() { start, end });
            }
            intervals = res.Select(x => x.ToArray()).ToArray();
            return intervals;
        }
    }
}