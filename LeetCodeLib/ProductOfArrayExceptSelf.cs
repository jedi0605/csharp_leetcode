using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] lArr = new int[nums.Length];
            int[] rArr = new int[nums.Length];
            int[] res = new int[nums.Length];

            lArr[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                lArr[i] = nums[i - 1] * lArr[i - 1];
            }

            rArr[nums.Length - 1] = 1;
            for (int i = nums.Length - 1; i > 0; i--)
            {
                rArr[i - 1] = nums[i] * rArr[i];
            }
            for (int i = 0; i < nums.Length; i++)
                res[i] = lArr[i] * rArr[i];
            return res;
        }
    }
}