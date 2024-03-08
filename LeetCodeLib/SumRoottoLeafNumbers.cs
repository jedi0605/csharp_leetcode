using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel;

namespace LeetCodeLib
{
    /// <summary>
    /// LeetCode 129. Sum Root to Leaf Numbers
    /// 1.DFS Stack to track total sum.
    /// </summary>
    /// 

    public static class SumRoottoLeafNumbers
    {
        public static int SumNumbers(TreeNode root)
        {
            return _dfs(root, 0);
        }
        public static int _dfs(TreeNode curr, int val)
        {
            if (curr == null) 
                return 0;
            
            int v = val * 10 + curr.val.Value;
            if (curr.left == null && curr.right == null) // leaf node
                return v;
            
            int l = _dfs(curr.left, v);
            int r = _dfs(curr.right, v);
            return l + r;
        }
    }
}