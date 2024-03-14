using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class ValidateBinarySearchTree2
    {
        /// <summary>
        /// Leetcode 98. Validate Binary Search Tree
        /// 1. Inorder treval will get order of numbers. compare pre val and curr val
        /// 2. DFS
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsValidBST(TreeNode root)
        {
            long left = long.MinValue;
            long right = long.MaxValue;
            return _dfsHelper(root, left, right);
        }

        private static bool _dfsHelper(TreeNode root, long left, long right)
        {
            if (root == null) return true;
            // left < root.val < right
            if ((left < root.val.Value) == false || (root.val.Value < right) == false)
                return false;
            bool lR = _dfsHelper(root.left, left, root.val.Value);
            bool rR = _dfsHelper(root.right, root.val.Value, right);
            return lR && rR;
        }

        // Stack inorder dfs version
        //  public static bool IsValidBST(TreeNode root)
        // {
        //     Stack<TreeNode> stack = new Stack<TreeNode>();
        //     var curr = root;
        //     TreeNode pre = null;
        //     while (curr != null || stack.Count > 0)
        //     {
        //         while (curr != null)
        //         {
        //             stack.Push(curr);
        //             curr = curr.left;
        //         }
        //         curr = stack.Pop();
        //         if (pre != null && pre.val.Value >= curr.val.Value)
        //             return false;
        //         pre = curr;
        //         curr = curr.right;
        //     }
        //     return true;
        // }
    }
}