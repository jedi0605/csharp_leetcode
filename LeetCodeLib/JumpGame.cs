using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class JumpGame
    {
        public static bool CanJump(int[] nums)
        {
            bool res = false;
            int goal = 1;
            for (int i = nums.Length - 1 - 1; i >= 0; i--)
            {
                if ((nums[i] - goal) >= 0)
                    goal = 1;
                else
                    goal++;
            }
            return goal == 1 ? true : false;
        }

        public static bool CanJump2(int[] nums)
        {
            int jumpPow = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                jumpPow--;
                jumpPow = Math.Max(jumpPow, nums[i]);
                // no power to keep going
                if (jumpPow == 0 && i != nums.Length - 1)
                    return false;
            }
            return true;
        }
    }
}