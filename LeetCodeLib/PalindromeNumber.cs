using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x == 0)
                return true;
            if (x % 10 == 0 || x < 0)
                return false;

            int revese = 0;
            // revers half way.
            while (x > revese)
            {
                int last = x % 10;
                x = x / 10;
                revese = (revese * 10) + last;
            }

            if (x == revese || x == revese / 10)
                return true;
            else
                return false;
        }
    }
}