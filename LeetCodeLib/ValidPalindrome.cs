using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Input: s = "A man, a plan, a canal: Panama"
    /// Output: true
    /// Explanation: "amanaplanacanalpanama" is a palindrome.
    /// 
    /// Input: s = "race a car"
    /// Output: false
    /// Explanation: "raceacar" is not a palindrome.
    /// 
    /// By using Stack to reverse string
    /// Key note [^a-zA-Z0-9] to rgx
    /// </summary>
    public static class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
            {
                return true;
            }

            // Replace all non alpha
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            string afterClean = rgx.Replace(s, "");
            afterClean = afterClean.Replace(" ", "").ToLower();

            char[] reversed = afterClean.ToCharArray();
            Array.Reverse(reversed);
            return new string(reversed) == afterClean;
            // Stack<char> reverseStack = new Stack<char>();
            // foreach (var item in afterClean)
            // {
            //     reverseStack.Push(item);
            // }
            // while (reverseStack.Count > 0)
            // {
            //     reverse += reverseStack.Pop();
            // }

            // return afterClean == reverse;
        }

    }
}