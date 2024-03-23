using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 211. Design Add and Search Words Data Structure 2
    /// Using Trie Tree
    /// #Leetcode 150    
    /// O(n)
    /// O(n)
    /// </summary>
    public class WordDictionary2
    {
        private class TrieNode
        {
            public bool WordEnd;
            public Dictionary<char, TrieNode> childern;
            public TrieNode()
            {
                childern = new Dictionary<char, TrieNode>();
            }
        }
        private TrieNode root = null;
        public WordDictionary2()
        {
            this.root = new TrieNode();
        }

        public void AddWord(string word)
        {
            TrieNode curr = this.root;
            foreach (var item in word)
            {
                if (!curr.childern.ContainsKey(item))
                    curr.childern.Add(item, new TrieNode());

                curr = curr.childern[item];
            }
            curr.WordEnd = true;
        }

        public bool Search(string word)
        {
            return DFS(word, this.root);
        }

        private bool DFS(string word, TrieNode node)
        {
            TrieNode curr = node;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '.')
                {
                    foreach (var item in curr.childern)
                    {
                        if (DFS(word.Substring(i + 1), item.Value))
                            return true;
                    }
                    return false;
                }
                else
                {
                    if (!curr.childern.ContainsKey(word[i]))
                        return false;
                    curr = curr.childern[word[i]];
                }
            }
            return curr.WordEnd;
        }
    }
}