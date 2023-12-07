using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class IntergerToRoman
    {
        public static string IntToRoman(int num)
        {
            List<(int, string)> maps = new List<(int, string)>();
            maps.Add((1000, "M"));
            maps.Add((900, "CM"));
            maps.Add((500, "D"));
            maps.Add((400, "CD"));
            maps.Add((100, "C"));
            maps.Add((90, "XC"));
            maps.Add((50, "L"));
            maps.Add((40, "XL"));
            maps.Add((10, "X"));
            maps.Add((9, "IX"));
            maps.Add((5, "V"));
            maps.Add((4, "IV"));
            maps.Add((1, "I"));

            string res = string.Empty;
            // foreach (var item in maps)
            // {
            //     int count = num / item.Item1;
            //     for (int i = 0; i < count; i++)
            //         res += item.Item2;
            //     num %= item.Item1;
            // }

            foreach (var item in maps)
            {
                while (num >= item.Item1)
                {
                    res += item.Item2;
                    num -= item.Item1;
                }
            }

            return res;
        }
    }
}