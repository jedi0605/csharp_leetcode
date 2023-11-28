using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class MajorityElement2
    {
        /// <summary>
        /// Leetcode 169 follow up question
        /// Using time O(n), space O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement(int[] nums)
        {
            int majority = nums.Length / 2 + 1;
            int counter = 0;
            int res = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (counter == 0)
                    res = nums[i];
                if (counter > majority)
                    return res;

                if (res == nums[i])
                    counter++;
                else
                    counter--;                
            }
            return res;
        }
    }
}