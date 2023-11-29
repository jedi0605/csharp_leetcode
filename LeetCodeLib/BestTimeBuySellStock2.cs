using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class BestTimeBuySellStock2
    {
        /// <summary>
        /// leetcode 122. tips: just tracking the increse pairs.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if(prices[i-1]< prices[i])
                    profit+= prices[i] - prices[i-1];
            }
            return profit;
        }
    }
}