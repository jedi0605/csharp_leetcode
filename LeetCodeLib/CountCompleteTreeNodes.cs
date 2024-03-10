using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Runtime.CompilerServices;

namespace LeetCodeLib
{
    /// <summary>
    /// 222. Count Complete Tree Nodes
    /// 1. Using DFS to count all node. time:O(n) space:O(h)
    /// 2. Find sub complete Tree, count by using 2^h - 1
    ///     Find most left, right hight.
    /// #Leetcode150
    /// 
    /// </summary>
    public class CountCompleteTreeNodes
    {
        public int CountNodes(TreeNode root)
        {
            if (root == null) return 0;
            int lH = _leftH(root);
            int rH = _rightH(root);
            if (lH == rH)
                return (int)(Math.Pow(2, lH) - 1);
            else
                return 1 + this.CountNodes(root.left) + this.CountNodes(root.right);
        }

        private int _rightH(TreeNode root)
        {
            if (root == null)
                return 0;
            return _rightH(root.right) + 1;
        }

        private int _leftH(TreeNode root)
        {
            if (root == null)
                return 0;
            return _leftH(root.left) + 1;
        }
        // private int count = 0;
        // public int CountNodes(TreeNode root)
        // {
        //     _dfs(root);
        //     return count;
        // }

        // private void _dfs(TreeNode root)
        // {
        //     if (root == null) return;
        //     count++;
        //     _dfs(root.left);
        //     _dfs(root.right);
        // }
    }
}