using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class DisjointSet547
    {
        public static DisjointSet547 FromMatrix(int[][] matrix)
        {
            var n = matrix.Length;

            DisjointSet547 set = new DisjointSet547(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        // Union two nodes if they are marked connected within matrix
                        set.Union(i, j);
                    }
                }
            }
            return set;
        }

        public int[] _node;
        public int[] _rank;
        public int Graphs = 0;
        public DisjointSet547(int n)
        {
            _node = new int[n];
            _rank = new int[n];
            Graphs = n;
            for (int i = 0; i < n; i++)
            {
                _node[i] = i;
                _rank[i] = 1;
            }
        }

        /// <summary>
        /// Find the parent node
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Find(int node)
        {
            while (node != _node[node])
            {
                node = _node[node];
            }
            return node;
        }

        public void Union(int a, int b)
        {
            a = Find(a);
            b = Find(b);
            if (a == b) // Same parent
                return;

            if (_rank[a] > _rank[b])
            {
                _node[b] = a;
                _rank[a] += _rank[b];
            }
            else
            {
                _node[a] = b;
                _rank[b] += _rank[a];
            }
            Graphs--;
        }
    }

    /// <summary>
    /// Disjoint DS
    /// A [1,1,0]
    /// B [1,1,0]
    /// C [0,0,1]
    /// A--B, C
    /// </summary>
    public static class FindCircleNum
    {
        public static int CircleNum(int[][] isConnected)
        {
            return DisjointSet547.FromMatrix(isConnected).Graphs;
        }
    }
}