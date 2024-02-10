using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class WordPattern
    {
        public static bool IsWordPattern(string pattern, string s)
        {
            string[] sArr = s.Split(' ');
            if (pattern.Length != sArr.Length)
                return false;

            Dictionary<char, string> patternToString = new Dictionary<char, string>();
            Dictionary<string, char> stringToPattern = new Dictionary<string, char>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if ((patternToString.ContainsKey(pattern[i]) && patternToString[pattern[i]] != sArr[i]) ||
                    (stringToPattern.ContainsKey(sArr[i]) && stringToPattern[sArr[i]] != pattern[i]))
                    return false;

                patternToString[pattern[i]] = sArr[i];
                stringToPattern[sArr[i]] = pattern[i];
            }
            return true;
        }
    }
}