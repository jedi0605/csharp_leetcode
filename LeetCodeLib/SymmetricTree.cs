using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SymmetricTree
    {
        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return isEquealDFS(root.left, root.right);

            // arrR = TravelTreeByR(root.right);            
        }

        private static bool isEquealDFS(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            if (left.val != right.val) return false;

            return isEquealDFS(left.left, right.right) && isEquealDFS(left.right, right.left);
        }
    }
}