using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class DiameterOfBinaryTree
    {
        public static int GetDiameterOfTree(TreeNode root)
        {
            return 0;
        }

        public static int GetHeight(TreeNode node)
        {
            if (node == null) return 0;
            return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
        }
    }
}