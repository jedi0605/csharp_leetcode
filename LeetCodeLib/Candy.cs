using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class Candy
    {
        public int GetCandy(int[] ratings)
        {
            int[] res = new int[ratings.Length];

            for (int i = 0; i < res.Length; i++)
                res[i] = 1;

            for (int i = 1; i < res.Length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                    res[i] = res[i - 1] + 1;
            }

            for (int i = res.Length - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1] && res[i] <= res[i + 1])
                    res[i] = res[i + 1] + 1;
            }
            return res.Sum();
        }
    }
}