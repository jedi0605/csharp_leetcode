using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstringSlidingWindow(string s)
        {
            int max = 0;
            int aPointer = 0;// point start;
            int bPointer = 0;// window end;
            HashSet<char> maps = new HashSet<char>();
            while (bPointer < s.Length)
            {
                if (!maps.Contains(s[bPointer]))
                {
                    maps.Add(s[bPointer]);
                    max = Math.Max(max, maps.Count);
                    bPointer++;
                }
                else
                {
                    maps.Remove(s[aPointer]);                    
                    aPointer++;
                }
            }
            return max;
        }

        /// <summary>
        /// brute force
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            int res = 0;

            for (int i = 0; i < s.Length; i++)
            {
                Dictionary<char, bool> maps = new Dictionary<char, bool>();
                int counter = 0;
                int subStart = i;
                while (subStart < s.Length && !maps.ContainsKey(s[subStart]))
                {
                    maps.Add(s[subStart], true);
                    counter++;
                    subStart++;
                }
                res = Math.Max(counter, res);
            }
            return res;
        }
    }
}