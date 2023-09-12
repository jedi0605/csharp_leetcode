using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class MinimumHeightTrees
    {
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            if (n == 1)
                return new[] { 0 };

            var adj = new HashSet<int>[n];

            foreach (var pair in edges)
            {
                if (adj[pair[0]] == null)
                    adj[pair[0]] = new HashSet<int>();
                if (adj[pair[1]] == null)
                    adj[pair[1]] = new HashSet<int>();

                adj[pair[0]].Add(pair[1]);
                adj[pair[1]].Add(pair[0]);
            }

            Queue<int> leaves = new Queue<int>();
            for (int i = 0; i < n; i++)
                if (adj[i].Count == 1)
                    leaves.Enqueue(i);

            while (n > 2)
            {
                var qSize = leaves.Count;
                for (var i = 0; i < qSize; i++)
                {
                    n--;
                    // current remove.
                    var thisNode = leaves.Dequeue();
                    // remove connection from adj.
                    var neighbor = adj[thisNode].Single();
                    adj[neighbor].Remove(thisNode);
                    if (adj[neighbor].Count == 1)
                        leaves.Enqueue(neighbor);
                }
            }

            return leaves.ToList();
        }
    }
}