using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{

    /// <summary>
    /// Leetcode 104. Maximum Depth of Binary Tree
    /// DFS search
    /// </summary>
    public static class MaximumDepthOfBinaryTree2
    {
        public static int MaxDepth(TreeNode root)
        {
            return _DFS(root);
        }
        public static int _DFS(TreeNode root)
        {
            if (root == null) return 0;
            int leftV = _DFS(root.left);
            int rightV = _DFS(root.right);
            return 1 + Math.Max(leftV, rightV);
        }
    }
}