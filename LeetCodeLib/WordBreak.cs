using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class WordBreak
    {
        /// <summary>
        /// array[^1] == array[length-1]. quick way to point end of the array.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="wordDict"></param>
        /// <returns></returns>
        public static bool Check(string s, IList<string> wordDict)
        {
            HashSet<string> sets = wordDict.ToHashSet();
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;   // dp[i] means substring before i can be segmented
            for (int start = 0; start < s.Length; start++)
            {
                if (dp[start])
                {
                    for (int end = start + 1; end < s.Length + 1; end++)
                    {
                        string subString = s.Substring(start, end - start);
                        if (sets.Contains(subString))
                            dp[end] = true;
                    }
                }
            }
            return dp[^1];
        }
    }
}