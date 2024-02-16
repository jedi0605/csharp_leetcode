using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class LongestConsecutiveSequence
    {
        // [100,4,200,1,3,2]
        public static int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;

            HashSet<int> maps = new HashSet<int>(nums);
            int longest = 0;

            foreach (var item in maps)
            {
                if (!maps.Contains(item - 1))
                {
                    int length = 1;
                    while (maps.Contains(item + length))
                        length++;
                    longest = Math.Max(length, longest);
                }
            }
            return longest;
        }
    }
}