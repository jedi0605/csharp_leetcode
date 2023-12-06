using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            int res = 0;
            int[] maxL = new int[height.Length];
            int[] maxR = new int[height.Length];

            int mL = 0;
            for (int i = 0; i < height.Length; i++)
            {
                maxL[i] = mL;
                mL = Math.Max(height[i], maxL[i]);
            }

            int mR = 0;
            for (int i = height.Length - 1; i >= 0; i--)
            {
                maxR[i] = mR;
                mR = Math.Max(height[i], maxR[i]);
            }

            // int[] minLR = new int[height.Length];
            for (int i = 0; i < height.Length; i++)
            {
                int minLR = Math.Min(maxL[i], maxR[i]);
                if ((minLR - height[i]) > 0)
                    res += minLR - height[i];
            }
            return res;
        }

        public int Trap2(int[] height)
        {
            int res = 0;
            int l = 0;
            int r = height.Length - 1;
            int maxL = height[l];
            int maxR = height[r];

            while (l < r)
            {
                if (maxL < maxR)
                {                   
                    l++;
                    maxL = Math.Max(maxL, height[l]);
                    res += maxL-height[l];
                }
                else
                {                  
                    r--;
                    maxR = Math.Max(maxR,height[r]);
                    res += maxR-height[r];
                }
            }
            return res;
        }
    }
}