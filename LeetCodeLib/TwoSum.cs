using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /*
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order.

        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

        Input: nums = [3,2,4], target = 6
        Output: [1,2]

        Input: nums = [3,3], target = 6
        Output: [0,1]
    */
    public static class TwoSum
    {
        public static int[] Run(int[] nums, int target)
        {
            int[] output = new int[2];
            // need num and index, key store value, value store index.
            // So if input is 9 
            // foreach dictionary target - key[i] = next value
            // chech have next value. if not move on.

            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int nextValue = target - nums[i];
                if (map.ContainsKey(nextValue))
                {
                    return new int[] {map[nextValue],i};
                }
                else
                {
                    if(!map.ContainsKey(nums[i]))
                        map.Add(nums[i],i);
                }
            }
            return output;
        }
    }
}