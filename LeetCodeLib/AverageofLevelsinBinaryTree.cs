using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// LeetCode 637. Average of Levels in Binary Tree
    /// BFS to travel every level
    /// Queue. use .Any() is more efficient
    /// </summary>

    public static class AverageofLevelsinBinaryTree
    {
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            if (root == null) return null;
            List<double> res = new List<double>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Any())
            {
                int c = q.Count;
                double avg = 0;
                for (int i = 0; i < c; i++)
                {
                    TreeNode curr = q.Dequeue();
                    avg += curr.val.Value;
                    if (curr.left != null)
                        q.Enqueue(curr.left);
                    if (curr.right != null)
                        q.Enqueue(curr.right);
                }
                res.Add(avg / c);
            }
            return res;
        }
    }
}