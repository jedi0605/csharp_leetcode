using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class EvaluateReversePolishNotation
    {
        public static int EvalRPN(string[] tokens)
        {
            Stack<int> nums = new Stack<int>();
            int res = 0;
            foreach (var item in tokens)
            {
                if (item == "+" || item == "-" || item == "*" || item == "/")
                {
                    int v1 = nums.Pop();
                    int v2 = nums.Pop();

                    int tmp = Operation(v2, item, v1);
                    nums.Push(tmp);

                }
                else
                {
                    nums.Push(int.Parse(item));
                }
            }
            return nums.Pop();
        }

        private static int Operation(int v1, string item, int v2)
        {
            if (item == "+")
                return v1 + v2;
            else if (item == "-")
                return v1 - v2;
            else if (item == "*")
                return v1 * v2;
            else
                return v1 / v2;
        }
    }
}