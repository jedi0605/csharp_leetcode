using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class LongestSubstringWithoutRepeatingCharacters2
    {
        public static int LengthOfLongestSubstringSlidingWindow2(string s)
        {
            HashSet<char> charSet = new HashSet<char>();
            int l = 0;
            int res = 0;

            for (int i = 0; i < s.Length; i++)
            {
                while (charSet.Contains(s[i]))
                {
                    res = Math.Max(res, charSet.Count);
                    charSet.Remove(s[l]);
                    l++;
                }
                charSet.Add(s[i]);
            }
            res = Math.Max(charSet.Count,res);
            return res;
        }

    }
}