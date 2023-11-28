using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            LinkedList<int> ints = new LinkedList<int>(nums);
            for (int i = 0; i < k; i++)
            {
                ints.AddFirst(ints.Last.Value);
                ints.RemoveLast();
            }
            var head = ints.First;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = head.Value;
                head = head.Next;
            }
        }

        public void Rotate2(int[] nums, int k)
        {
            k = k % nums.Length;
            if (nums.Length <= 1 || k == 0) return;

            _reverse(nums, 0, nums.Length - k - 1);

            _reverse(nums, nums.Length - k, nums.Length - 1);

            _reverse(nums, 0, nums.Length - 1);
        }

        public void _reverse(int[] nums, int start, int end)
        {
            for (int i = 0; i <= (end - start) / 2; i++)
            {
                int tmp = nums[i + start];
                nums[i + start] = nums[end - i];
                nums[end - i] = tmp;
            }
        }
    }
}