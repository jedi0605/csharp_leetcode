using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class CountBits
    {

        /// <summary>
        /// Explane
        ///10 > Binary 1 total Cout
        /// 0 > 0 # 0
        /// 1 > 1 # 01
        /// 2 > 1 # 10
        /// 3 > 2 # 11
        /// 4 > 1 #100
        /// 5 > 2 #101
        /// 6 > 2 #110
        /// 7 > 3 #111
        /// 8 > 1 #01000
        /// 
        /// [0] > 0
        /// [1] > 1
        ///      power = 2
        /// [2] > 1+ dp[i-power] > 1 + 1
        /// [3] > 1+ dp[i-power] > 1 + 1
        ///      power = 4
        /// [4] > 1+ dp[i-power] > 1 + 0
        /// so on...
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] CountBit(int n)
        {
            if (n == 0)
                return new int[] { 0 };
            if (n == 1)
                return new int[] { 0, 1 };

            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            int power = 1;
            for (int i = 2; i < n + 1; i++)
            {
                if (power * 2 == i)
                    power = i;
                dp[i] = 1 + dp[i - power];
            }
            return dp;
        }
    }
}