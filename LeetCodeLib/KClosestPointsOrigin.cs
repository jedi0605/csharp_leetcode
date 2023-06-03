using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// PriorityQueue
    /// </summary>
    public static class KClosestPointsOrigin
    {
        public static int[][] KClosest(int[][] points, int k)
        {
            PriorityQueue<int[], double> minHeap = new();

            // dis, x, y
            List<(int, int, double)> res = new List<(int, int, double)>();

            for (int i = 0; i < points.Length; i++)
            {
                int x = points[i][0];
                int y = points[i][1];
                double dis = Math.Pow(x, 2) + Math.Pow(y, 2);
                // res.Add((x, y, dis));
                minHeap.Enqueue(points[i],dis);
            }
           
            int[][] output = new int[k][];
            for (int i = 0; i < k; i++)
            {
                output[i] = minHeap.Dequeue();
            }
            return output;
        }
    }
}