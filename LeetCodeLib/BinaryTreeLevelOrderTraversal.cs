using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class BinaryTreeLevelOrderTraversal
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();

            IList<IList<int>> res = new List<IList<int>>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                int size = q.Count;
                List<int> tmp = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    TreeNode n = q.Dequeue();
                    tmp.Add(n.val.Value);
                    if (n.left != null)
                        q.Enqueue(n.left);
                    if (n.right != null)
                        q.Enqueue(n.right);
                }
                res.Add(tmp);
            }
            return res;

        }
    }
}