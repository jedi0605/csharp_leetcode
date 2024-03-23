using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 211. Design Add and Search Words Data Structure
    /// Dic <int,List<string>> -> len(word), [word.....]
    /// Using word len to be key in Dictionary and append word in to the List
    /// #Leetcode 150    
    /// O(n)
    /// O(n)
    /// </summary>
    public class WordDictionary
    {
        private Dictionary<int, List<string>> maps = null;

        public WordDictionary()
        {
            maps = new Dictionary<int, List<string>>();
        }

        public void AddWord(string word)
        {
            int len = word.Length;
            this.maps.TryAdd(len, new List<string>());
            this.maps[len].Add(word);
        }

        public bool Search(string word)
        {
            int len = word.Length;
            if (maps.ContainsKey(len) == false)
                return false;
            bool match = false;
            foreach (var item in maps[len])
            {
                for (int i = 0; i < len; i++)
                {
                    if (word[i] != '.' && word[i] != item[i])
                    {
                        match = false;
                        break;
                    }
                    else
                        match = true;
                }
                if (match) return true;
            }
            return match;
        }
    }
}