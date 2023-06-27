using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class Permutations
    {
        public static IList<IList<int>> res = new List<IList<int>>();
        public static IList<IList<int>> Permute(int[] nums)
        {
            BackTracking(new HashSet<int>(), nums);
            return res;
        }

        private static void BackTracking(HashSet<int> list, int[] nums)
        {
            if (list.Count == nums.Length)
            {
                res.Add(new List<int>(list)); // deep copy
                return;
            }

            foreach (var item in nums)
            {
                if (list.Add(item))
                {
                    BackTracking(list,nums);
                    list.Remove(item);
                }
            }
        }
    }
}