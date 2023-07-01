using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class LowestCommonAncestorOfABinaryTree
    {
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            if (root.val == p.val || root.val == q.val)
                return root;

            TreeNode leftLca = LowestCommonAncestor(root.right, p, q);
            TreeNode rightLca = LowestCommonAncestor(root.left, p, q);
            if (leftLca != null && rightLca != null)
                return root;

            if (leftLca != null)
                return leftLca;
            else
                return rightLca;
        }
    }
}