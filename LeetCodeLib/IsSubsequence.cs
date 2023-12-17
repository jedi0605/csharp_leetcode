using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class IsSubsequence
    {
        public static bool IsSub(string s, string t)
        {
            if (string.IsNullOrEmpty(s))
                return true;
                
            int i = 0;
            int j = 0;
            while (i < t.Length)
            {
                if (t[i] == s[j])
                    j++;

                if (j == s.Length)
                    break;
                i++;
            }

            return j == s.Length ? true : false;
        }

        static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}