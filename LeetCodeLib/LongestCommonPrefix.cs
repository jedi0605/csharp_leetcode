using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class LongestCommonPrefix
    {
        public static string GetCommonPrefix(string[] strs)
        {
            int shortestIndex = 0;
            int shortestLength = 201;
            // pick up shortest string in strs.
            for (int i = 0; i < strs.Count(); i++)
            {
                if (strs[i].Length < shortestLength)
                {
                    shortestIndex = i;
                    shortestLength = strs[i].Length;
                }
            }
            string prefix = string.Empty;
            for (int i = 0; i < strs[shortestIndex].Length; i++)
            {
                foreach (var item in strs)
                {
                    if (item[i] != strs[shortestIndex].ElementAt(i))
                        return prefix;
                }
                prefix = prefix + strs[shortestIndex].ElementAt(i);
            }
            return prefix;
        }
    }
}