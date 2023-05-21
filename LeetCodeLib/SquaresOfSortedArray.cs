using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SquaresOfSortedArray
    {
        public static int[] SortedSquares(int[] nums)
        {
            int[] res = new int[nums.Length];
            int left = 0;
            int right = nums.Length - 1;
            int indexOfnew = nums.Length - 1;

            while (0 <= indexOfnew)
            {
                int leftNum = nums[left] * nums[left];
                int rightNum = nums[right] * nums[right];
                if (rightNum < leftNum)
                {
                    res[indexOfnew] = leftNum;
                    left++;
                }
                else
                {
                    res[indexOfnew] = rightNum;
                    right--;
                }
                indexOfnew--;
            }

            return res;
        }
    }
}