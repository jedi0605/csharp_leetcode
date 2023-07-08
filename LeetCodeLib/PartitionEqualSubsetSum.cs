using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class PartitionEqualSubsetSum
    {
        public static bool CanPartition2(int[] nums)
        {
            //https://www.youtube.com/watch?v=z_VLFGzQQtk
            int sum = nums.Sum();

            //since two equal partions' sum will be absolutely EVEN number!!
            if (sum % 2 != 0) return false;

            //try to find any subset's sum can be sum/2
            int target = sum / 2;
            bool[] dp = new bool[target + 1];
            //when sum=0, the result is true(can be achieved) 

            dp[0] = true;
            foreach (int num in nums)
            {
                //must start from the most right one(from backward)
                //curSum means "index" of the boolean array
                for (int curSum = target; curSum > 0; curSum--)
                {
                    //make sure "num" is NOT above the range
                    if (curSum - num >= 0)
                    {
                        //select || not select for this time(num)
                        dp[curSum] = dp[curSum] || dp[curSum - num];
                    }
                }
            }
            return dp[target];
        }

        public static bool CanPartition(int[] nums)
        {
            int target = nums.Sum();
            if (target % 2 != 0) return false;
            target = target / 2;

            // 1, 5, 11, 5
            /*.   nums[index]     nextSet                         set
                0.    0(default)                                 [0]
                1.    5      -> [0]                           -> [5, 0]
                2.   11      -> [5, 0]                        -> [16, 5, 11, 0]
                3.    5      -> [16, 5, 11, 0]                -> [21, 16, 10, 5, 16, 11, 5, 0]
                4.    1      -> [21, 16, 10, 5, 16, 11, 5, 0] -> [22, 21, 17, 16, 11, 10, 6, 5, 17, 16, 12, 11, 6, 5, 1, 0]
            */
            HashSet<int> set = new HashSet<int>();
            set.Add(0); // default

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                HashSet<int> nextSet = new HashSet<int>();
                foreach (var item in set)
                {
                    nextSet.Add(nums[i] + item);
                    nextSet.Add(item);
                }
                set = nextSet;
            }
            return set.Contains(target);
        }
    }
}