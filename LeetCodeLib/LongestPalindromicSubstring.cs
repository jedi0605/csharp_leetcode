using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Brust force will be n^3
    /// abba
    /// Generate all sub string will cost N^2 
    /// a, ab, abb, abba, b, bb,bba, b(x), ba, a(x) 
    /// check palindrome will cost N
    /// 
    /// using expand check every single chat to expend left and right. and check is equal. 
    /// abba 
    /// </summary>

    public static class LongestPalindromicSubstring
    {
        static int maxLen = 0;
        static int lo = 0;
        public static string LongestPalindrome(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                ExpandPalindrome(s, i, i);
                ExpandPalindrome(s, i, i + 1);
            }
            return s.Substring(lo, maxLen);
        }

        // aabbaa
        /// <summary>
        /// aabbaa
        /// if 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public static void ExpandPalindrome(string s, int start, int end)
        {
            while (start >= 0 && end < s.Length && s[start] == s[end])
            {
                start--;
                end++;
            }
            if (maxLen < end - start - 1)
            {
                maxLen = end - start - 1;
                lo = start + 1;
            }
        }
    }
}