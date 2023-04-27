using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class BestTime2BuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int start = prices[0];
            int maxTranProfit = 0;
            int lostest = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < lostest)
                    lostest = prices[i];

                if (prices[i] - lostest > maxTranProfit)
                {
                    maxTranProfit = prices[i] - lostest;
                }
                // start = prices[i];
            }
            return maxTranProfit;
        }
    }
}