using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class CoinChange
    {
        public static int Change(int[] coins, int amount)
        {
             // Array.Sort(coins);
            if (amount == 0)
                return 0;
            int[] dp = new int[amount + 1];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = amount + 1;
            }
            dp[0] = 0;
            for (int i = 1; i < dp.Length; i++)
            {
                foreach (var item in coins)
                {
                    if (item <= i)
                    {
                        dp[i] = Math.Min(dp[i - item] + 1, dp[i]); // pick a coint and ref forward.
                    }
                }
            }
            return dp[amount] > amount ? -1 : dp[amount];
            // int count = 0;

            // for (int i = coins.Length - 1; i >= 0; i--)
            // {
            //     if (amount < coins[i])
            //         continue;
            //     int cur = coins[i];
            //     int curCount = amount / cur;
            //     count += curCount;
            //     amount = amount - curCount * cur;
            // }
            // if(amount != 0) return -1;
            // return count;
        }
    }
}