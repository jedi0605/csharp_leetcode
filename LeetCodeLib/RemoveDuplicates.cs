using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class RemoveDuplicates
    {
        public int Sol(int[] nums)
        {
            int l = 1;
            for (int r = 1; r < nums.Length; r++)
            {
                if (nums[r] != nums[r - 1])
                {
                    nums[l] = nums[r];
                    l++;
                }
            }
            return l;           
        }
    }
}