using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace LeetCodeLib
{

    /// <summary>
    /// Leetcode 399. Evaluate Division
    /// Create Map old<->new
    /// BFS to see all neighbors.
    /// Time O(n) Space O(n)
    /// </summary>
    public class EvaluateDivision
    {
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            List<double> res = new List<double>();
            Dictionary<string, List<(string, double)>> graph = this.GetGraph(equations, values);

            // 2. BFS 
            foreach (var item in queries)
            {
                string src = item[0];
                string target = item[1];
                double value = this.bfs(src, target, graph);
                res.Add(value);
            }
            return res.ToArray();
        }

        private double bfs(string src, string target, Dictionary<string, List<(string, double)>> graph)
        {
            if (graph.ContainsKey(src) == false || graph.ContainsKey(target) == false)
                return -1;
            Queue<(string, double)> q = new Queue<(string, double)>();
            HashSet<string> visited = new HashSet<string>();
            q.Enqueue((src, 1));
            visited.Add(src);
            while (q.Any())
            {
                var (num, w) = q.Dequeue();
                if (num == target)
                    return w;
                foreach (var item in graph[num])
                {
                    var (adjNum, adjW) = item;
                    if (visited.Contains(adjNum) == false)
                    {
                        q.Enqueue((adjNum, w * adjW));
                        visited.Add(adjNum);
                    }
                }
            }
            return -1;
        }

        private Dictionary<string, List<(string, double)>> GetGraph(IList<IList<string>> equations, double[] values)
        {
            Dictionary<string, List<(string, double)>> graph = new Dictionary<string, List<(string, double)>>();
            // 1. graph
            for (int i = 0; i < equations.Count; i++)
            {
                IList<string> ab = equations[i];
                string a = ab[0];
                string b = ab[1];
                if (graph.ContainsKey(a))
                    graph[a].Add((b, values[i]));
                else
                    graph[a] = new List<(string, double)>() { (b, values[i]) };
                if (graph.ContainsKey(b))
                    graph[b].Add((a, 1 / values[i]));
                else
                    graph[b] = new List<(string, double)>() { (a, 1 / values[i]) };
            }
            return graph;
        }
    }
}