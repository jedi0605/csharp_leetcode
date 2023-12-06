using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 62. DP problem
    /// 
    /// S,0,0,0
    /// 0,0,0,0
    /// 0,0,0,1   < end
    /// 
    /// S,0,0,0
    /// 0,0,0,0
    /// 0,0,0,1   < end, How many ways can get to the EDN
    /// 
    /// S,0,0,0
    /// 0,0,0,0
    /// 1,1,1,1   < end, How many ways can get to the EDN
    /// 
    /// S,0,0,0
    /// 0,0,2,1   < [1][2] will be 2, bcz [1][3] + [2][2] and so on
    /// 1,1,1,1   < end, How many ways can get to the EDN
    /// 
    /// 10,6,3,1
    /// 4,3,2,1   < [1][2] will be 2, bcz [1][3] + [2][2] and so on
    /// 1,1,1,1   < end, How many ways can get to the EDN
    /// </summary>
    public static class UniquePaths
    {
        public static int GetPaths(int m, int n)
        {
            int[,] arr = new int[m, n];

            // last row will init to 1 > only one choose to last corner
            for (int i = 0; i < n; i++)
            {
                arr[m - 1, i] = 1;
            }

            for (int i = 0; i < m; i++)
            {
                arr[i, n - 1] = 1;
            }

            for (int i = m - 2; i >= 0; i--)
            {
                for (int j = n - 2; j >= 0; j--)
                {
                    arr[i, j] = arr[i + 1, j] + arr[i, j + 1];
                }
            }

            return arr[0, 0];
        }
    }
}