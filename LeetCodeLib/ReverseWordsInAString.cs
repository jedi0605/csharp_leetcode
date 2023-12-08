using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class ReverseWordsInAString
    {
        public static string ReverseWords(string s)
        {
            string res = string.Empty;
            string[] arr = s.Trim().Split(' ');

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == "")
                    continue;
                else
                {
                    res = res + arr[i] + " ";
                }
            }

            return res.Trim();
        }
        public static string ReverseWords2(string s)
        {
            string[] arr = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            int j = arr.Length - 1;

            while (i < j)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
                i++;
                j--;
            }
            return string.Join(" ", arr);
        }
    }
}