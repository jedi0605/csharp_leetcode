using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class ReverseBits
    {
        public static uint reverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                result <<= 1; // Shift right
                result = result | (n & 1); // result + n&1(means get last bit to & operation 0&1=0, 1&1=1);
                 n >>= 1;
            }
            return result;
        }
    }
}