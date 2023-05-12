using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class MaximumDepthOfBinaryTree
    {
        public static int MaxDepth(TreeNode root)
        {
            return _DFS(root);
        }

        private static int _DFS(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = _DFS(root.left);
            int right = _DFS(root.right);
            return Math.Max(left, right) + 1;
        }
    }
}