using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            int high = nums.Length - 1;
            int low = 0;
            int middle = 0;

            while (low <= high)
            {
                middle = (high + low) / 2;
                if (nums[middle] == target) //
                    return middle;
                // left or right
                if (nums[middle] < target) // target in right
                {
                    low = middle + 1;
                }
                else
                    high = middle - 1;
            }
            return -1;
        }

        public static int BinarySearchRecursive(int[] num, int target, int hight, int low)
        {
            if (low > hight)
                return -1;

            int mid = (hight + low) / 2;
            if (num[mid] == target)
                return mid;
            else if (num[mid] < target) // target in right side.
            {
                low = mid + 1;
                return BinarySearchRecursive(num, target, hight, low);
            }
            else
            {
                hight = mid - 1;
                return BinarySearchRecursive(num, target, hight, low);
            }
        }
    }
}