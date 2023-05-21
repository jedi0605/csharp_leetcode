using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SubtreeOfAnotherTree
    {
        public static bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null) return false;
            if (isSame(root, subRoot)) return true;
            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        private static bool isSame(TreeNode s, TreeNode t)
        {
            if (s == null || t == null) return s == t;

            if (s.val != t.val) return false;

            return isSame(s.left, t.left) && isSame(s.right, t.right);
        }
    }
}