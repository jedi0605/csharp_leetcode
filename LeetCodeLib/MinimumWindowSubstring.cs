using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class MinimumWindowSubstring
    {
        public static string MinWindow(string s, string t)
        {
            Dictionary<char, int> countT = new Dictionary<char, int>();

            // init countT
            for (int i = 0; i < t.Length; i++)
            {
                if (countT.ContainsKey(t[i]))
                    countT[t[i]]++;
                else
                    countT.Add(t[i], 1);
            }

            Dictionary<char, int> window = new Dictionary<char, int>();
            int have = 0;
            int need = countT.Count;
            int resLen = int.MaxValue;
            int l = 0;
            int resR = 0;
            int resL = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (window.ContainsKey(c))
                    window[c]++;
                else
                    window.Add(c, 1);

                if (window.ContainsKey(c) && countT.ContainsKey(c) && window[c] == countT[c])
                    have++;

                while (have == need)
                {
                    int currLen = i - l + 1;
                    if (currLen < resLen)
                    {
                        resLen = currLen;
                        resL = l;
                        resR = i;
                    }

                    if (window.ContainsKey(s[l]))
                        window[s[l]]--;
                    if (window.ContainsKey(s[l]) && countT.ContainsKey(s[l]) && window[s[l]] < countT[s[l]])
                        have--;
                    l++;
                }
            }

            if (resLen == int.MaxValue)
                return "";
            else
                return s.Substring(resL, resR - resL + 1);
        }
    }
}