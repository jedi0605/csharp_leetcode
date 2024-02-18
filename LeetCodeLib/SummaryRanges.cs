using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class SummaryRanges
    {

        public static IList<string> Summary_Ranges(int[] nums)
        {
            List<string> res = new List<string>();
            if (nums.Length == 0)
                return res;
            int s = nums[0];
            int e = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > e + 1) // nums[i] is not contiue.
                {
                    if (s != e) // is a range
                        res.Add(s.ToString() + "->" + e.ToString());
                    else
                        res.Add(s.ToString());
                    s = nums[i];
                    e = nums[i];
                }
                else
                {
                    e = nums[i];
                }
            }

            if (s != e) // is a range            
                res.Add(s.ToString() + "->" + e.ToString());
            else
                res.Add(s.ToString());

            return res;
        }
    }
}