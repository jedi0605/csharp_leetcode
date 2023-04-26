using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class ValidParentheses
    {
        /*
        Example 1:
        Input: s = "()"
        Output: true

        Example 2:
        Input: s = "()[]{}"
        Output: true

        Example 3:
        Input: s = "(]"
        Output: false
        */
        /// First instinct is about queue or stack
        /// [ ( { add to stack else pop first one to check with s[i]
        /// Stack > push, pop
        public static bool IsValid(string s)
        {
           
            Stack<char> stackString = new Stack<char>();
            // odd -> false
            if (s.Length % 2 != 0)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine(s[i]);
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    stackString.Push(s[i]);
                else
                {
                    if (stackString.Count == 0) // edge case
                        return false;

                    char check = stackString.Pop();
                    if (check != opposite(s[i]))
                        return false;
                }
            }

            return stackString.Count == 0 ? true : false;
        }

        private static char opposite(char a)
        {
            if (a == ')')
                return '(';

            else if (a == ']')
                return '[';
            else
                return '{';
        }
    }
}