using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Ref by https://www.youtube.com/watch?v=3vZV-6qPDmE
    /// DFS with tracking
    /// </summary>
    public static class DiameterOfBinaryTree
    {
        static int MaxDiameter = 0;
        public static int GetDiameterOfTree(TreeNode root)
        {
            MaxDiameter = 0;
            GetHeight(root);
            return MaxDiameter;
        }

        public static int GetHeight(TreeNode node)
        {
            if (node == null) return 0;
            int lH = GetHeight(node.left);
            int rH = GetHeight(node.right);
            MaxDiameter = Math.Max(MaxDiameter, lH + rH); // lH + rH
            return 1 + Math.Max(lH, rH);
        }
    }
}