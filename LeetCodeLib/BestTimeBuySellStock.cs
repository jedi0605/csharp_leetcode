using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// using two pointer to track profit
    /// </summary> <summary>
    /// 
    /// </summary>
    public class BestTimeBuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int l = 0;
            int r = 0;

            while (r < prices.Length)
            {
                if(prices[l] < prices[r])
                {
                    int profit = prices[r] - prices[l];
                    maxProfit = Math.Max(profit,maxProfit);
                }
                else                
                    l = r;            
                r++;
            }

            return maxProfit;
        }
    }
}