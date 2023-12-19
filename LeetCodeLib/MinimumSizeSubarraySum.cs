using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class MinimumSizeSubarraySum
    {
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int total = 0;
            int res = 1000000000;
            int l = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
                while (total >= target)
                {
                    res = Math.Min(i - l + 1, res);
                    total -= nums[l];
                    l++;
                }
            }
            return res == 1000000000 ? 0 : res;
        }
    }
}