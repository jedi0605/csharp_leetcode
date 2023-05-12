using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class BackspaceCompare
    {
        public static bool Compare(string s, string t)
        {
            s = ReplaceSharp(s);
            t = ReplaceSharp(t);
            return s == t;
        }
        private static string ReplaceSharp(string s)
        {
            int indexS = s.IndexOf('#');
            while (indexS != -1)
            {
                if (indexS == 0)
                    s = s.Remove(indexS,1);
                else
                {

                    string replaceTarget = s[indexS - 1].ToString() + "#";
                    s = s.Replace(replaceTarget, "");
                }
                indexS = s.IndexOf('#');
            }
            return s;
        }
    }
}