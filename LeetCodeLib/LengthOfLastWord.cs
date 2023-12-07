using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class LengthOfLastWord
    {
        public static int LengthLastWord(string s)
        {
            string[] split = s.Trim().Split(' ');
            string lastWord = split[split.Length - 1];
            return lastWord.Length;
        }
    }
}