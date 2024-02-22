using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SimplifyPath
    {
        /// <summary>
        /// Leetcode 71. Simplify Path
        /// Split path:
        /// 1. ".."
        /// 2. "." , "" > do nothing
        /// 3. stack push
        /// In the end using StringBuilder to build result
        /// .Insert(0,stack(pop))
        /// #Leetcode150
        /// Time:O(n)
        /// Space:O(n)
        public static string Simplify_Path(string path)
        {
            string res = string.Empty;
            Stack<string> stack = new Stack<string>();

            foreach (var item in path.Split("/"))
            {
                if (item == "..")
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else if (item == "." || item == string.Empty)
                    continue;
                else
                {
                    stack.Push(item);
                }
            }

            var result = new StringBuilder();
            while (stack.Count > 0)
            {
                result.Insert(0, stack.Pop());
                result.Insert(0, "/");
            }
            return result.Length == 0 ? "/" : result.ToString();
        }
    }
}