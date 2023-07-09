using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class Subsets
    {
        /// <summary>
        /// O (2^N)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> GetSubsets(int[] nums)
        {
            if (nums.Length == 0) return null;
            List<IList<int>> res = new List<IList<int>>();
            Stack<int> curr = new Stack<int>();
            BackTracking(nums, 0, curr, res);
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="index">for keep tracking</param>
        /// <param name="curr">this loop ans</param>
        /// <param name="res"></param>
        public static void BackTracking(int[] nums, int index, Stack<int> curr, IList<IList<int>> res)
        {
            res.Add(new List<int>(curr)); // deep copy of curr
            for (int i = index; i < nums.Length; i++)
            {
                curr.Push(nums[i]);
                BackTracking(nums, i + 1, curr, res);
                curr.Pop();
            }
        }
    }
}