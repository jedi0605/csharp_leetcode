using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 224. Basic Calculator
    /// Part1. Build basic calculator without ()
    /// #Leetcode 150
    /// #Stack
    /// O(1)
    /// O(n)
    public class BasicCalculator
    {
        public static int Calculate(string s)
        {
            var res = 0;
            var num = 0; // current parse num
            int sign = 1; // deal with -+
            Stack<int> stack = new Stack<int>();
            // s = (1+(4+5+2)-3)+(6+8)
            foreach (var item in s)
            {
                int parseVal = 0;

                if (int.TryParse(item.ToString(), out parseVal))
                    num = num * 10 + parseVal;
                else if (item == '+' || item == '-')
                {
                    res += num * sign;
                    num = 0;
                    if (item == '+') sign = 1;
                    else sign = -1;
                }
                // part2 deal with () operator
                else if (item == '(') // store current res to stack
                {
                    stack.Push(res);
                    stack.Push(sign);
                    sign = 1;
                    res = 0;
                }
                else if (item == ')')
                {
                    res += num * sign;
                    res *= stack.Pop();
                    res += stack.Pop();
                    num = 0;
                }
            }
            return res + num * sign;
        }
    }
}