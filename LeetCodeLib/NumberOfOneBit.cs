using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class NumberOfOneBit
    {
        public static int HammingWeight2(uint n)
        {
            int count = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    count++;
                }

                n >>= 1;
            }
            return count;
        }

        public static int HammingWeight(uint n)
        {
            string c = Convert.ToString(n, 2);
            return c.Count(x => x == '1');
        }
    }
}