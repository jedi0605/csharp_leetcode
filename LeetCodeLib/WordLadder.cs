using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class WordLadder
    {
        /// <summary>
        /// LeetCode 127. Word Ladder
        /// Make word possible mutaion like "hot" to "*ot, h*t, ho*". to a maps.
        /// {"*ot", [hot, dot]}
        /// Do BFS
        /// Add to hashset or check with bank
        /// ***** Must using hashset ***** Huge diff between IList<string>
        /// </summary>
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (!wordList.Contains(endWord)) return 0;
            Dictionary<string, List<string>> maps = new Dictionary<string, List<string>>();
            foreach (var item in wordList)
            {
                for (int i = 0; i < beginWord.Length; i++)
                {
                    string mutaWord = item.Substring(0, i) + "*" + item.Substring(i + 1, item.Length - i - 1);
                    maps.TryAdd(mutaWord, new List<string>());
                    maps[mutaWord].Add(item);
                }
            }
            HashSet<string> visited = new HashSet<string>();
            Queue<(string, int)> q = new Queue<(string, int)>();
            q.Enqueue((beginWord, 1));

            while (q.Any())
            {
                (string cur, int steps) = q.Dequeue();
                for (int i = 0; i < beginWord.Length; i++)
                {
                    string mutaWord = cur.Substring(0, i) + "*" + cur.Substring(i + 1, cur.Length - i - 1);
                    if (maps.ContainsKey(mutaWord) == false)
                        continue;
                    foreach (var item in maps[mutaWord])
                    {
                        if (item == endWord)
                            return steps + 1;
                        if (visited.Contains(item) == false)
                        {
                            q.Enqueue((item, steps + 1));
                            visited.Add(item);
                        }
                    }
                }
            }

            return 0;
        }
    }
}