using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace LeetCodeLib
{

    /// <summary>
    /// Leetcode 133. Clone Graph
    /// Create Map old<->new
    /// BFS to see all neighbors.
    /// Time O(n) Space O(n)
    /// </summary>
    public static class CloneGraph2
    {
        public static Node DeepCloneGraph(Node node)
        {
            if (node == null) return null;
            Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();
            Queue<Node> q = new Queue<Node>();
            oldToNew.Add(node, new Node(node.val));
            q.Enqueue(node);
            while (q.Any())
            {
                Node cur = q.Dequeue();
                foreach (var item in cur.neighbors)
                {
                    if (!oldToNew.ContainsKey(item))
                    {
                        oldToNew[item] = new Node(item.val);
                        q.Enqueue(item);
                    }
                    oldToNew[cur].neighbors.Add(oldToNew[item]);
                }
            }
            return oldToNew[node];
        }
    }
}