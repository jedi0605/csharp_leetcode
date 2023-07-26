using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 1220. Count Vowels Permutation
    /// 
    /// based on which letters a vowel will follow we update its current count based on the letters occurance it follow
    //as per problem
    //a will follow e i and u,  so record[2][a] = record[1][e] + record[1][i] + record[1][u]        
    //n = 1  2 ...
    //a   1  3 (e,i,u)
    //e   1  2 (a,i)
    //i   1  2 (e,o)
    //o   1  1 (i)
    //u   1  2 (i,o)
    //tot=  10

    //Indexes 
    // a = 0
    // e = 1
    // i = 2
    // o = 3
    // u = 4
    /// a > e
    /// e > a i
    /// i > a e o u 
    /// o > i u
    /// u > a
    /// </summary>
    public class CountStringPermutations
    {
        public static int countPerms(int n)
        {
            long[][] dp = new long[n][];
            dp[0] = new long[5] { 1, 1, 1, 1, 1 };
            int MOD = 1_000_000_007;
            for (int i = 1; i < n; i++)
            {
                dp[i] = new long[5];
                dp[i][0] = dp[i - 1][1];
                dp[i][1] = (dp[i - 1][0] + dp[i - 1][2]) % MOD;
                dp[i][2] = (dp[i - 1][0] + dp[i - 1][1] + dp[i - 1][3] + dp[i - 1][4]) % MOD;
                dp[i][3] = (dp[i - 1][2] + dp[i - 1][4]) % MOD;
                dp[i][4] = dp[i - 1][0];
            }
            return (int)(dp[n - 1].Sum() % MOD);
            // if (n == 1)
            //     return 5;
            // int[,] dp = new int[n, 5];
            // /// init. dp 
            // dp[0, 0] = 1;
            // dp[0, 1] = 1;
            // dp[0, 2] = 1;
            // dp[0, 3] = 1;
            // dp[0, 4] = 1;

            // for (int i = 1; i < n; i++)
            // {
            //     dp[i, 0] = (dp[i - 1, 1] + dp[i - 1, 2] + dp[i - 1, 4]) % mod;
            //     dp[i, 1] = (dp[i - 1, 0] + dp[i - 1, 2]) % mod;
            //     dp[i, 2] = (dp[i - 1, 1] + dp[i - 1, 3]) % mod;
            //     dp[i, 3] = (dp[i - 1, 2]) % mod;
            //     dp[i, 4] = (dp[i - 1, 2] + dp[i - 1, 3]);
            // }
            // long res = 0;
            // for (int i = 0; i < 5; i++)
            // {
            //     res += dp[n - 1, i];
            //     res %= mod;
            // }
            // return (int)res;
        }
    }
}