using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class LongestPalindrome
    {
        public static int Longest(string s)
        {
            int longest = 0;
            Dictionary<char, int> maps = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (maps.ContainsKey(item))
                {
                    maps[item]++;
                }
                else
                {
                    maps.Add(item, 1);
                }
            }

            foreach (var item in maps)
            {
                longest += item.Value / 2 * 2;
                if (longest % 2 == 0 && item.Value % 2 == 1)
                {
                    longest++;
                }
            }
            return longest;
        }
    }
}