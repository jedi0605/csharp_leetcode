using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SearchInRotatedSortedArray
    {
        ///[4,5,6,7,0,1,2]
        /// find the breaking point to deside search left or right
        public static int MinIndex(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int middel = left + (right - left) / 2;
                if (nums[middel] > nums[right])
                {
                    left = middel + 1;
                }
                else
                    right = middel;
            }
            return left;
        }

        public static int Search(int[] nums, int target)
        {
            int minIndex = MinIndex(nums);
            int min = 0;
            int max = nums.Length - 1;

            if (target >= nums[minIndex] && target <= nums[max])
                min = minIndex;
            else
                max = minIndex;
            while (min <= max)
            {
                int mid = min + (max - min) / 2;

                if (nums[mid] == target)
                    return mid;

                if (nums[mid] > target)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return -1;
        }

    }
}