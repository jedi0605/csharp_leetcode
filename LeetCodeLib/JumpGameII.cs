using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class JumpGameII
    {
        public static int Jump(int[] nums)
        {
            int step = 0;
            int l = 0;
            int r = 0;

            while (r < nums.Length - 1)
            {
                int farest = 0;
                for (int i = l; i <= r; i++)
                    farest = Math.Max(i + nums[i], farest);

                l = r + 1;
                r = farest;
                step++;
            }
            return step;
        }
    }
}