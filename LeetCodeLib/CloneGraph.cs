using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }

    public static class CloneGraph
    {
        public static Node DeepCloneGraph(Node node)
        {
            if(node==null) return null;
            Queue<Node> q = new Queue<Node>();
            Dictionary<Node, Node> visted = new Dictionary<Node, Node>(); // tracking the old node and link new node
            q.Enqueue(node);
            visted.Add(node, new Node(node.val)); // clone list

            while (q.Any())
            {
                Node cur = q.Dequeue();
                foreach (var item in cur.neighbors)
                {
                    if (!visted.ContainsKey(item))
                    {
                        visted.Add(item, new Node(item.val));
                        q.Enqueue(item);
                    }
                    visted[cur].neighbors.Add(visted[item]);
                }
            }
            return visted[node];
        }
    }
}