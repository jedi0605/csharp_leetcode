using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class MinimumNumberOfArrowsToBurstBalloons
    {
        /// <summary>
        /// Leetcode 452. Minimum Number of Arrows to Burst Balloons
        /// #Leetcode 150
        /// #Intervals
        /// #Sort
        /// O(nlogn)
        /// O(n)
        public static int FindMinArrowShots(int[][] points)
        {
            if (points.Length == 0) return 0;
            int res = 1;
            // sort points[][]
            List<int[]> tmpPoints = new List<int[]>(points);
            tmpPoints = tmpPoints.OrderBy(x => x[0]).ToList();
            int[] pre = new int[] { tmpPoints.First()[0], tmpPoints.First()[1] };

            for (int i = 1; i < tmpPoints.Count; i++)
            {
                if ( pre[1]<tmpPoints[i][0]) // not overlapping
                {
                    res++;
                    pre = tmpPoints[i];
                }
                else
                {
                    pre[1] = Math.Min(pre[1], tmpPoints[i][1]);
                }
            }
            return res;
        }
    }
}