using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 1) return intervals;
            List<List<int>> res = new List<List<int>>();
            int resCount = 0;

            List<List<int>> interList = intervals.Select(x => x.ToList()).ToList().OrderBy(x=>x[0]).ToList();
            res.Add(interList[0]);


            for (int i = 1; i < interList.Count; i++)
            {
                if (res[resCount][1] < interList[i][0]) // don't need merge
                {
                    res.Add(interList[i]);
                    resCount++;
                }
                else
                {
                    if (res[resCount][1] >= interList[i][0])
                    {
                        res[resCount][1] = interList[i][1];
                    }
                }
            }
            return res.Select(x => x.ToArray()).ToArray();
        }
    }
}