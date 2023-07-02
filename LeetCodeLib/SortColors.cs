using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SortColors
    {
        public static void Sort2(int[] nums)
        {
            int length = nums.Length;
            int start = 0; // always point the 0 spot
            int end = nums.Length - 1; // always point 2 spot
            int index = 0;
            while (index <= end && start < end)
            {
                if (nums[index] == 0)
                {
                    nums[index] = nums[start];
                    nums[start] = 0;
                    index++;
                    start++;
                }
                else if (nums[index] == 2)
                {
                    nums[index] = nums[end];
                    nums[end] = 2;
                    end--;
                }
                else
                    index++;
            }
        }
        public static void Sort(int[] nums)
        {
            int zero = 0;
            int one = 0;
            int two = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    zero++;
                else if (nums[i] == 1)
                    one++;
                else
                    two++;
            }

            for (int i = 0; i < zero; i++)
            {
                nums[i] = 0;
            }

            for (int i = zero; i < zero + one; i++)
            {
                nums[i] = 1;
            }

            for (int i = zero + one; i < zero + one + two; i++)
            {
                nums[i] = 2;
            }
        }

    }
}