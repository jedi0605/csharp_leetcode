using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class MaximumSubarray
    {
        /// <summary>
        /// [-2,2,5,-11,6]
        /// index0,maxS = -2 currentS = -2
        /// index1,maxS = -2+2 currentS = 2
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0];// maxSum
            int currentSum = maxSum;
            for (int i = 1; i < nums.Length; i++)
            {
                // compare num[i]+current or choose new start
                // -2 + 2 or 2 >> 2
                // 2 + 5 or 5 >> 7
                // 7 -11 or -11 >> 7
                // 7 
                currentSum = Math.Max(nums[i] + currentSum, nums[i]);
                maxSum = Math.Max(currentSum, maxSum);
            }

            return maxSum;
        }
    }
}