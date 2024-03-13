using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel;

namespace LeetCodeLib
{
    /// <summary>
    /// LeetCode 103. Binary Tree Zigzag Level Order Traversal
    /// </summary>

    public class BinaryTreeZigzagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            if (root == null) return null;
            List<IList<int>> res = new List<IList<int>>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Any())
            {
                List<int> levelArr = new List<int>();
                int c = q.Count;
                for (int i = 0; i < c; i++)
                {
                    var cur = q.Dequeue();
                    levelArr.Add(cur.val.Value);
                    if (cur.left != null)
                        q.Enqueue(cur.left);
                    if (cur.right != null)
                        q.Enqueue(cur.right);
                }
                if (res.Count % 2 == 1)
                    levelArr.Reverse();
                res.Add(levelArr);
            }
            return res;
        }
    }
}