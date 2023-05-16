using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{

    /// <summary>
    /// Keep traking earliest 0, and first non-0 value to swap.
    /// 
    /// Value:[0,1,0,3,12]
    ///        | |
    /// Value:[1,0,0,3,12]
    ///          |   |
    /// Value:[1,3,0,0,12]
    ///            |    |
    /// Value:[1,3,12,0,0]
    /// </summary>
    public static class MoveZeroes
    {
        public static void Move(int[] nums)
        {

            int l = 0; // left pointer
            // int j = 0; // first non-0 value pointer

            for (int r = 0; r < nums.Length; r++)
            {
                if (nums[r] != 0)
                {
                    int tmp = nums[l];
                    nums[l] = nums[r];
                    l++;
                    nums[r] = tmp;
                }
            }            
        }
    }
}