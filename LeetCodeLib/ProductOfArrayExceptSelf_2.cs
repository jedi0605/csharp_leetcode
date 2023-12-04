using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class ProductOfArrayExceptSelf_2
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] res = new int[nums.Length];
            int[] forward = new int[nums.Length];
            forward[0] = 1;

            for (int i = 1; i < nums.Length; i++)
                forward[i] = nums[i - 1] * forward[i - 1];

            int prefix = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                res[i] = prefix * forward[i];
                prefix = nums[i] * prefix;
            }
            return res;
        }
    }
}