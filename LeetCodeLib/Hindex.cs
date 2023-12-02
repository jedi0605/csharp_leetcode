using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class Hindex
    {
        public static int GetIndex(int[] citations)
        {
            int res = 0;
            Array.Sort(citations);
            int N = citations.Length;
            for (int i = 0; i < citations.Length; i++)
            {
                if (N - i <= citations[i])
                    res++;
            }

            return res;
        }

        public static int GetIndex2(int[] citations)
        {
            int res = 0;
            Array.Sort(citations);
            for (int i = citations.Length - 1; i >= 0; i--)
            {
                if (citations[i] > res)
                    res++;
            }

            return res;
        }
    }
}