using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class StringToIntegerAtoi
    {
        public static int MyAtoi(string s)
        {
            List<char> chars = new();
            s = s.TrimStart(' ');
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    chars.Add(s[i]);
                    continue;
                }
                if (i == 0 && s[0] == '-')
                    continue;
                if (i == 0 && s[0] == '+')
                    continue;
                break;
            }
            if (chars.Count == 0)
                return 0;
            bool cor = int.TryParse(String.Join("", chars), out int result);
            if (cor && s[0] == '-')
                return -result;
            if (cor)
                return result;
            if (!cor && s[0] == '-')
                return int.MinValue;
            else
                return int.MaxValue;
        }
    }
}