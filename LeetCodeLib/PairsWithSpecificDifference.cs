using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class PairsWithSpecificDifference
    {
        public static int[,] FindPairsWithGivenDifference(int[] arr, int k)
        {

            HashSet<int> set = new HashSet<int>(arr);
            List<(int, int)> tmp = new List<(int, int)>();

            for (int i = 0; i < arr.Length; i++)
            {
                int x = k + arr[i];
                if (set.Contains(x))
                    tmp.Add((x, arr[i]));
            }

            if (tmp.Count == 0) return null;
            
            int[,] res = new int[tmp.Count, 2];
            
            for (int i = 0; i < tmp.Count; i++)
            {
                res[i,0] = tmp[i].Item1;
                res[i,1] = tmp[i].Item2;
            }
            return res;
        }
    }
}