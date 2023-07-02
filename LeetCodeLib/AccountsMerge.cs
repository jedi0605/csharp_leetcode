using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class DisjointSet721
    {
        public List<int> parent = new();
        List<int> size = new();
        public DisjointSet721(int V)
        {
            for (int i = 0; i < V; i++)
            {
                parent.Add(i);
                size.Add(1);
            }
        }

        public int FindUParent(int node)
        {
            while (node != parent[node])
                node = parent[node];
            return node;
        }

        public void UnionBySize(int u, int v)
        {
            int ulpu = FindUParent(u);
            int ulpv = FindUParent(v);
            if (ulpu == ulpv)
                return;

            if (size[ulpu] < size[ulpv])
            {
                parent[ulpu] = ulpv;
                size[ulpv] = size[ulpv] + size[ulpu];
            }
            else
            {
                parent[ulpv] = ulpu;
                size[ulpu] = size[ulpu] + size[ulpv];
            }
        }
    }

    /// <summary>
    /// Leetcode #721. Accounts Merge
    /// Union find data structure.
    /// https://haogroot.com/2021/01/29/union_find-leetcode/
    /// </summary>
    public static class AccountsMerge
    {
        public static IList<IList<string>> Merge(IList<IList<string>> accounts)
        {
            /// <summary>
            /// Create a email base dictionary.
            /// email -> accountIndex.
            /// if email exist -> add to disjoin set.
            /// </summary>
            /// <returns></returns>
            Dictionary<string, int> dict = new();
            DisjointSet721 ds = new DisjointSet721(accounts.Count);

            for (int i = 0; i < accounts.Count; i++)
            {
                for (int j = 1; j < accounts[i].Count; j++) // loop all email
                {
                    if (dict.ContainsKey(accounts[i][j]))
                        ds.UnionBySize(dict[accounts[i][j]], i); //ds.UnionBySize(existAccount, current loop account)
                    else
                        dict.Add(accounts[i][j], i); // dict.Add(email,loop current account)
                }
            }
            // Merge All account.
            List<(string name, List<string> email)> mergeResult = new List<(string name, List<string> email)>();
            for (int i = 0; i < accounts.Count; i++)// init mergeResult
                mergeResult.Add((accounts[i][0], new List<string>()));
            foreach (var item in dict)
            {
                int parent = ds.FindUParent(item.Value);
                mergeResult[parent].email.Add(item.Key);
            }

            // conver to result
            IList<IList<string>> res = new List<IList<string>>();
            foreach (var item in mergeResult)
            {
                if (item.email.Count == 0) continue;
                List<string> tmp = new List<string>() { item.name };
                item.email.Sort(StringComparer.Ordinal);
                tmp.AddRange(item.email);
                res.Add(tmp);
            }
            return res;
        }
    }
}