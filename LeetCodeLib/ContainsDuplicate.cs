using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class ContainsDuplicate
    {
        public static bool CheckDuplicate(int[] nums)
        {
            Dictionary<int, int> checkedMap = new Dictionary<int, int>();
            try
            {
                foreach (var item in nums)
                {
                    checkedMap.Add(item, 1);
                }
                return false;
            }
            catch (System.Exception)
            {
                return true;
            }
        }
    }
}