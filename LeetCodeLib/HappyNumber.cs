using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            HashSet<int> maps = new HashSet<int>();

            while (n > 0)
            {
                n = numOfSquare(n);
                if (n == 1)
                    return true;
                if (maps.Contains(n))
                    return false;
                maps.Add(n);
            }
            return false;
        }
        private int numOfSquare(int n)
        {
            int res = 0;
            while (n > 0)
            {
                int digit = n % 10;
                digit = digit * digit;
                res += digit;
                n = n / 10;
            }
            return res;
        }
    }
}