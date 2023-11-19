using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class RemoveElement
    {
        public int RemoveElementBF(int[] nums, int val)
        {
            int res = 0;
            foreach (var item in nums)
            {
                if(item!=val)
                {
                    nums[res] = item;
                    res++;
                }
            }
            return res;
        }
    }
}