using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class ValidParentheses2
    {
        /// <summary>
        /// Leetcode 20. Valid Parentheses. using stack to track parentheses.
        /// #Leetcode150
        /// Time:O(n)
        /// Space:O(n)
        public static bool IsValid(string s)
        {
            Stack<char> stackString = new Stack<char>();
            Dictionary<char, char> closeToOpen = new Dictionary<char, char>();
            closeToOpen.Add(']', '[');
            closeToOpen.Add(')', '(');
            closeToOpen.Add('}', '{');

            foreach (var item in s)
            {
                if (closeToOpen.ContainsKey(item))
                {
                    if (stackString.Count != 0 && stackString.Peek() == closeToOpen[item])
                        stackString.Pop();
                    else
                        return false;
                }
                else
                    stackString.Push(item);
            }
            return stackString.Count == 0;
        }

    }
}