using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class ThreeSum2
    {
        public static IList<IList<int>> Sum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int l = i + 1;
                int r = nums.Length - 1;
                while (l < r)
                {
                    int tmpSum = 0 - nums[i];
                    if (nums[l] + nums[r] == tmpSum)
                    {
                        res.Add(new List<int>() { nums[i], nums[l], nums[r] });
                        l++;
                        while (nums[l] == nums[l - 1] && l < r)
                            l++;
                    }

                    if (nums[l] + nums[r] > tmpSum)
                        r--;
                    else
                        l++;
                }
            }
            return res;
        }
    }
}