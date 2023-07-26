using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class BalanceSum
    {
        public static string BalancedSumString(List<int> arr)
        {
            int leftIndex = 0;
            int rightIndex = arr.Count - 1;
            while (leftIndex < rightIndex)
            {
                int sumOfLeft = arr.Take(leftIndex).Sum();
                int sumOfRight = arr.Skip(rightIndex).Sum();
                if (sumOfLeft == sumOfRight)
                    return (leftIndex) + "," + (rightIndex - 1);
                if (sumOfLeft < sumOfRight)
                    leftIndex++;
                if (sumOfRight < sumOfLeft)
                    rightIndex--;
            }
            return "";
        }
    }
}