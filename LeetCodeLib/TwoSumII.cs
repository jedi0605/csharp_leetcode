using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class TwoSumII
    {
        /// <summary>
        /// Using two pointer approach
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target)
                    break;

                if (sum > target)
                    right--;
                else
                    left++;
            }
            return new int[] { left + 1, right + 1 };
        }
    }
}