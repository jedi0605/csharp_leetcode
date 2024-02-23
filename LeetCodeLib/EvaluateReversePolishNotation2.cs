using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 150. Evaluate Reverse Polish Notation
    /// Foreach tokens:
    /// if token is operator:
    ///     pop() * 2 and calculate res and add back to stack
    /// else 
    ///     add to stack
    /// 
    /// * careful with -, / operator
    /// Input: tokens = ["4","13","5","/","+"]
    /// Output: 6
    /// Explanation: (4 + (13 / 5)) = 6
    /// a = stack.pop()
    /// b = stack.pop()
    /// b-a or b/a
    /// #Leetcode 150
    /// #Stack
    /// O(1)
    /// O(n)
    /// </summary>
    public static class EvaluateReversePolishNotation2
    {
        public static int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var item in tokens)
            {
                if (item == "+")
                {
                    stack.Push(stack.Pop() + stack.Pop());
                }
                else if (item == "-")
                {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b - a);
                }
                else if (item == "*")
                {
                    stack.Push(stack.Pop() * stack.Pop());
                }
                else if (item == "/")
                {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b / a);
                }
                else
                    stack.Push(int.Parse(item));
            }
            return stack.Pop();
        }
    }
}