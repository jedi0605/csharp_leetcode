using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class RansomNote
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> maps = new Dictionary<char, int>();
            foreach (var item in magazine)
            {
                if (maps.ContainsKey(item))
                    maps[item]++;
                else
                    maps.Add(item, 1);
            }

            foreach (var item in ransomNote)
            {
                if (maps.ContainsKey(item) == false)
                    return false;
                else
                {
                    int count = maps[item] - 1;
                    if (count < 0)
                        return false;
                    maps[item]--;
                }
            }

            return true;
        }
    }
}