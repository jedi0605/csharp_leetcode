using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class GroupAnagrams
    {
        public static IList<IList<string>> Group_Anagrams(string[] strs)
        {
            List<IList<string>> res = new List<IList<string>>();
            Dictionary<string, List<string>> maps = new Dictionary<string, List<string>>();

            foreach (var item in strs)
            {
                int[] counter = new int[26];
                for (int i = 0; i < item.Length; i++)
                    counter[item[i] - 'a']++;

                // Generate a unique key for each anagram based on character counts
                StringBuilder keyBuilder = new StringBuilder();
                for (int i = 0; i < 26; i++)
                {
                    if (counter[i] > 0)
                    {
                        keyBuilder.Append((char)('a' + i));
                        keyBuilder.Append(counter[i]);
                    }
                }

                string key = keyBuilder.ToString();

                if (maps.ContainsKey(key))
                    maps[key].Add(item);
                else
                    maps.Add(key, new List<string>() { item });
            }
            return new List<IList<string>>(maps.Values);
        }
    }
}