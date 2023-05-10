using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Input: n = 2
    /// Output: 2
    /// Explanation: There are two ways to climb to the top.
    /// 1. 1 step + 1 step
    /// 2. 2 steps
    /// 
    /// n = 3 
    /// 1. 1 step + 1 step + 1 step
    /// 2. 1 step + 2 steps
    /// 3. 2 steps + 1 step
    /// </summary>
    public static class ClimbStairs
    {
        // DP Problem 
        public static int Climb(int n)
        {
            if(n==1)
                 return 1;
            if(n==2)
                return 2;
            int firstStep = 1;
            int secondStep = 2;
            int currentStep = 0;
            for (int i = 2; i < n; i++)
            {
                currentStep  = firstStep+secondStep;
                firstStep = secondStep;
                secondStep = currentStep;
            }
            return currentStep;
        }
    }
}