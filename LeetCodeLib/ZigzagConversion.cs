using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class ZigzagConversion
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            string res = string.Empty;
            int count = s.Length;
            int totalLen = s.Length;

            for (int i = 0; i < numRows; i++)
            {
                int currnetIndex = i;
                int startIndex = i;
                if (startIndex == 0 || startIndex == numRows - 1)
                {
                    while (startIndex < totalLen)
                    {
                        res += s[startIndex];
                        startIndex += (numRows - 1) * 2;
                    }
                }
                else
                {
                    while (startIndex < totalLen)
                    {
                        res += s[startIndex];
                        int extra = startIndex + (numRows - 1) * 2 - 2 * i;
                        if (extra < totalLen)
                            res += s[extra];
                        startIndex += (numRows - 1) * 2;
                    }
                }
            }
            return res;
        }

        public static string Convert2(string s, int numRows)
        {
            if (numRows == 1) return s;

            // Build 2d array
            List<StringBuilder> rows = new List<StringBuilder>();
            for (int i = 0; i < numRows; i++)
                rows.Add(new StringBuilder());

            int currentRow = 0;
            bool goDown = false;
            foreach (char c in s)
            {
                rows[currentRow].Append(c);
                if (currentRow == 0 || currentRow == numRows - 1)
                    goDown = !goDown;

                if (goDown)
                    currentRow++;
                else
                    currentRow--;
            }
            StringBuilder res = new StringBuilder();
            foreach (var item in rows)
                res.Append(item.ToString());

            return res.ToString();
        }
        public static string Convert3(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            string res = string.Empty;
            int increment = (numRows - 1) * 2;
            for (int row = 0; row < numRows; row++)
            {
                for (int i = row; i < s.Length; i += increment)
                {
                    res += s[i];
                    if (row != 0 && row != numRows - 1 && i + increment - (2 * row) < s.Length)
                        res += s[i + increment - 2 * row];
                }
            }
            return res;
        }
    }
}
