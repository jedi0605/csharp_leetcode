using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    ///       1         <====
    ///      /  \       
    ///     2    3      <====      See This WAY
    ///    / \  / \
    ///      5     4    <====
    ///     /
    ///    7            <====
    /// </summary>
    public static class BinaryTreeRightSideView
    {
        static List<int> res = new List<int>();
        public static IList<int> RightSideView(TreeNode root)
        {
            if (root == null) return null;

            // _DFS(root, 1);
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                int size = q.Count;
                TreeNode rightestNode = null;
                for (int i = 0; i < size; i++)
                {
                    TreeNode current = q.Dequeue();
                    if (current != null)
                    {
                        rightestNode = current;
                        q.Enqueue(current.left);
                        q.Enqueue(current.right);
                    }
                }
                if (rightestNode != null) res.Add(rightestNode.val.Value);
            }
            return res;
        }
        static void _DFS(TreeNode node, int level)
        {
            if (node == null)
                return;
            if (level > res.Count)
                res.Add(node.val.Value);

            _DFS(node.right, level + 1);
            _DFS(node.left, level + 1);
        }
    }
}