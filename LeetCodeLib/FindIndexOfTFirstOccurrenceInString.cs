using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class FindIndexOfTFirstOccurrenceInString
    {
        public static int StrStr(string haystack, string needle)
        {
            int len = needle.Length;
            int startIdx = 0;
            // int endIdx = needle.Length - 1;
            if (haystack.Length < needle.Length)
                return -1;
            if (haystack.Length == needle.Length)
                return haystack == needle ? 0 : -1;

            while (startIdx <= haystack.Length - len)
            {
                string subStr = haystack.Substring(startIdx, needle.Length);
                if (subStr == needle)
                    return startIdx;
                startIdx++;
            }
            return -1;
        }
    }
}