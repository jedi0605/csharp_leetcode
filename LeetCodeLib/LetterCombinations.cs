using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class LetterCombinations
    {
        Dictionary<char, char[]> keypad = new Dictionary<char, char[]>
        {{'2', new char[]{'a', 'b', 'c'}},
        {'3', new char[]{'d', 'e', 'f'}}, {'4', new char[] {'g', 'h', 'i'}},
        {'5', new char[] {'j', 'k', 'l'}}, {'6', new char[] {'m', 'n', 'o'}},
        {'7', new char[] {'p', 'q', 'r', 's'}}, {'8', new char[] {'t', 'u', 'v'}},
        {'9', new char[] {'w', 'x', 'y', 'z'}}};
        /// <summary>
        /// 2 > abc
        /// 3 > def
        /// 4 > ghi
        /// For example. input is 34
        /// so combination will be d,e,f + g,h,i
        /// "dg" "dh" "di"
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public IList<string> Combinations(string digits)
        {
            IList<string> combinations = new List<string>();
            if (string.IsNullOrEmpty(digits))
                return combinations;
            AddCombination("", digits, 0, combinations);
            return combinations;
        }
        private void AddCombination(string curr, string digits, int index, IList<string> res)
        {
            if (curr.Length == digits.Length)
            {
                res.Add(curr);
            }
            else
            {
                char[] map = keypad[digits[index]];
                for (int i = 0; i < map.Length; i++)
                {
                    string newCurr = curr + map[i];
                    AddCombination(newCurr, digits, index + 1, res);
                }
            }
        }
    }
}