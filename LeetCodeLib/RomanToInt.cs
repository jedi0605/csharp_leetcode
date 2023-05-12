using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class RomanToInt
    {


        public static int ConvertToInt2(string s)
        {
            Dictionary<char, int> valueMap = new Dictionary<char, int>()
            {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000},
            };

            int result = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (valueMap[s[i]] < valueMap[s[i + 1]])
                    result -= valueMap[s[i]];
                else
                    result += valueMap[s[i]];
            }
            return result + valueMap[s[s.Length - 1]];
        }

        public static int ConvertToInt(string s)
        {
            int result = 0;
            Dictionary<string, int> valueMap = new Dictionary<string, int>()
            {
                {"I",1},
                {"V",5},
                {"X",10},
                {"L",50},
                {"C",100},
                {"D",500},
                {"M",1000},
            };
            if (s.Contains("CM"))
            {
                result += 900;
                s = s.Replace("CM", "");
            }

            if (s.Contains("CD"))
            {
                result += 400;
                s = s.Replace("CD", "");
            }

            if (s.Contains("XC"))
            {
                result += 90;
                s = s.Replace("XC", "");
            }

            if (s.Contains("XL"))
            {
                result += 40;
                s = s.Replace("XL", "");
            }
            if (s.Contains("IX"))
            {
                result += 9;
                s = s.Replace("IX", "");
            }

            if (s.Contains("IV"))
            {
                result += 4;
                s = s.Replace("IV", "");
            }

            foreach (var item in s)
            {
                result += valueMap[item.ToString()];
            }

            return result;
        }
    }
}