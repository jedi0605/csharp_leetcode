using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class RemoveDuplicatesFromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 3)
                return nums.Length;
            int index = 2;
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[index - 2])
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            return index;

        }
    }
}
