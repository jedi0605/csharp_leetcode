using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// all Ref. https://leetcode.com/problems/majority-element/editorial/
    /// Time and Space BigO example.
    /// </summary>
    public static class MajorityElement
    {
        /// <summary>
        /// Brust force.
        /// Also can sort the array. and nums[mid-index]
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int GetMajorityElement(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            Dictionary<int, int> maps = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (maps.ContainsKey(item))
                {
                    maps[item]++;
                    if (maps[item] > nums.Length / 2)
                        return item;
                }
                else
                    maps.Add(item, 1);

            }
            return 0;
        }

        /// <summary>
        /// Boyer–Moore majority vote algorithm (摩爾投票算法)。
        /// Candidate (record current majority value)
        /// Counter (majority value count)
        /// Core idea is vote and +- the counter
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int GetMajorityElementVote(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            int candidate = nums[0];
            int counter = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (counter == 0) //switch candidate
                    candidate = nums[i];

                if (candidate == nums[i])
                    counter++;
                else
                    counter--;
            }
            return candidate;
        }
    }
}