using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SearchInRotatedSortedArray2
    {
        public static int Search(int[] nums, int target)
        {
            int minIndex = GetMinIndex(nums);
            int left = 0; int right = nums.Length - 1;

            if (nums[minIndex] == target)
                return minIndex;

            if (nums[minIndex] <= target && target <= nums[right])
                left = minIndex;
            else
                right = minIndex;


            while (right >= left)
            {
                int middel = (right + left) / 2;
                if (nums[middel] == target)
                    return middel;
                if (nums[middel] > target)
                    right = middel - 1;
                else
                    left = middel + 1;
            }
            return -1;
        }

        public static int GetMinIndex(int[] nums)
        {
            int min = 0;
            int max = nums.Length - 1;
            int middle = 0;
            while (max > min)
            {
                middle = (max + min) / 2;
                if (nums[middle] > nums[max])
                    min = middle + 1;
                else
                    max = middle;
            }
            return min;
        }
    }
}