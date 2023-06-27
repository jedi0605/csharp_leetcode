using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class CombinationSum
    {

        /// <summary>
        /// using DFS list all combination of SUM        
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static IList<IList<int>> Sum(int[] candidates, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();
            List<int> tmpAns = new List<int>();
            _dfs(res, candidates, 0, tmpAns, target, 0);
            HashSet<int> t = new HashSet<int>();
            
            return res;
        }

        static void _dfs(IList<IList<int>> res, int[] candidates, int candIndex, List<int> tmpAns, int target, int total)
        {
            if (target == total)
            {
                List<int> ans = new List<int>(tmpAns);
                // tmpAns.ForEach(x => System.Diagnostics.Debug.Write(x));
                System.Diagnostics.Debug.WriteLine("***");
                res.Add(ans);
                return;
            }

            if (total > target || candIndex >= candidates.Length) return;
            tmpAns.Add(candidates[candIndex]);
            
            // tmpAns.ForEach(x => System.Diagnostics.Debug.Write(x));
            // System.Diagnostics.Debug.WriteLine("");

            _dfs(res, candidates, candIndex, tmpAns, target, total + candidates[candIndex]);
            tmpAns.Remove(candidates[candIndex]);

            // System.Diagnostics.Debug.WriteLine("Remove");
            // tmpAns.ForEach(x => System.Diagnostics.Debug.Write(x));
            // System.Diagnostics.Debug.WriteLine("");

            _dfs(res, candidates, candIndex + 1, tmpAns, target, total);
        }
    }
}