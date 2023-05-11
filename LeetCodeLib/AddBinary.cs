using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    ///  11
    ///   1
    /// 100
    /// </summary>
    public static class AddBinary
    {
        public static string Run(string a, string b)
        {
            StringBuilder output = new StringBuilder();

            int alength = a.Length - 1;
            int blength = b.Length - 1;
            int carry = 0;
            while (alength >= 0 || blength >= 0)
            {
                int sum = carry;
                if (alength >= 0)
                    sum += a[alength] - '0';

                if (blength >= 0)
                    sum += b[blength] - '0';

                output.Append(sum % 2);
                carry = sum / 2;  // Quick note. do not using if else to calculate carry. using / to avoid controll value.
                alength--;
                blength--;
            }
            if (carry == 1)
                output.Append(1);
            return new string(output.ToString().Reverse().ToArray());
        }

    }
}