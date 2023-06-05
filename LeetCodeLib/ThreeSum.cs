using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class ThreeSum
    {
        public static IList<IList<int>> Sum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 2; i++) // -2. to be sure in the array
            {
                if (nums[i] > 0) // if num[0] > 0. than no zero result.
                    break;
                if (i > 0 && nums[i] == nums[i - 1]) // skip the repeat nums.
                    continue;
                int low = i + 1;
                int end = nums.Length - 1;
                int sum = 0 - nums[i]; // target for two sum.

                while (low < end)
                {
                    if (nums[low] + nums[end] == sum)
                    {
                        res.Add(new List<int>() { nums[i], nums[low], nums[end] });
                        // avoid repeat nums
                        while (low < end && nums[low] == nums[low + 1]) low++;
                        while (low < end && nums[end] == nums[end - 1]) end--;
                        low++;
                        end--;
                    }
                    else if (nums[low] + nums[end] > sum)
                        end--;
                    else
                        low++;
                }
            }
            return res;
        }
    }
}