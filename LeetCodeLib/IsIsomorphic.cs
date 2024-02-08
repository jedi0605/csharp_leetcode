using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class IsIsomorphic
    {
        public static bool Is_Isomorphic(string s, string t)
        {
            Dictionary<char, char> mapST = new Dictionary<char, char>();
            Dictionary<char, char> mapTS = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char sChar = s[i];
                char tChar = t[i];
                if ((mapST.ContainsKey(sChar) && mapST[sChar] != tChar) ||
                     (mapTS.ContainsKey(tChar) && mapTS[tChar] != sChar))
                    return false;

                mapST[sChar] = tChar;
                mapTS[tChar] = sChar;
            }

            return true;
        }
    }
}