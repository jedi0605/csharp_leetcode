using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SymmetricTree2
    {
        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return _Dfs(root.left, root.right);

        }
        private static bool _Dfs(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;

            return left.val == right.val && _Dfs(left.left,right.right) && _Dfs(left.right,right.left);
        }
    }
}