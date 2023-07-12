using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class ContainerWithMostWater
    {
        public int MaxAreaBruteForce(int[] height)
        {
            int res = 0;
            for (int l = 0; l < height.Length - 1; l++)
            {
                for (int r = l + 1; r < height.Length; r++)
                {
                    int area = (r - l) * Math.Min(height[l], height[r]);
                    res = Math.Max(area, res);
                }
            }
            return res;
        }

        /// <summary>
        /// two pointer support.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            int res = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int area = (right - left) * Math.Min(height[left], height[right]);
                res = Math.Max(area, res);
                // move buttleneck
                if (height[left] > height[right])
                    right--;
                else
                    left++;
            }
            return res;
        }
    }
}