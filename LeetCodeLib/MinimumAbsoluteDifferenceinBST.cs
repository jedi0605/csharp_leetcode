using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel;
using System.Transactions;

namespace LeetCodeLib
{
    /// <summary>
    /// LeetCode 530. Minimum Absolute Difference in BST
    /// In BST tree. using inorder trevals will getting ordering array.
    /// Add Stack, And recurce ver.
    /// </summary>

    public class MinimumAbsoluteDifferenceinBST
    {
        private int res = int.MaxValue;
        private TreeNode pre = null;
        public int GetMinimumDifference(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode curr = root;
            while (stack.Count > 0 || curr != null)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                if (pre != null)
                    this.res = Math.Min(this.res, Math.Abs(pre.val.Value - curr.val.Value));
                pre = curr;
                curr = curr.right;
            }
            // inorder(root);
            return res;
        }
        /// <summary>
        /// [4,2,6,1,3]
        /// </summary>
        /// <param name="root"></param>
        private void inorder(TreeNode root)
        {
            if (root == null) return;

            inorder(root.left);
            if (pre != null)
                this.res = Math.Min(this.res, Math.Abs(pre.val.Value - root.val.Value));
            pre = root;
            inorder(root.right);
        }
    }
}