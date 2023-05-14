using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SingleNumber
    {
        public static int GetSingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }

    }
}