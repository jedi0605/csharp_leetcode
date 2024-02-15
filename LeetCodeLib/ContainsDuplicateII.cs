using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> maps = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (maps.ContainsKey(nums[i]))
                {
                    if (Math.Abs(maps[nums[i]] - i) <= k)
                        return true;
                    else
                        maps[nums[i]] = i;
                }
                else
                    maps.Add(nums[i], i);
            }
            return false;
        }
    }
}