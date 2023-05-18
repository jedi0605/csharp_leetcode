using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class MissingNumber
    {
        public static int GetMissingNumber(int[] nums)
        {
            int inputSums  = nums.Sum();
            int totalSum = 0;

            for (int i = 0; i <= nums.Length; i++)
            {
                totalSum+=i;
            }
            return totalSum - inputSums;
        }
    }
}