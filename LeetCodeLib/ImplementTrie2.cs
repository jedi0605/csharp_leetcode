using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// 208. Implement Trie (Prefix Tree)
    /// Store every word like tree.
    /// apple: a->p->p->l->e*
    /// ape:       ->e*
    /// #Leetcode 150    
    /// O(n)
    /// O(n)
    /// </summary>
    public class TrieNode2
    {
        public Dictionary<char, TrieNode2> childerns = new Dictionary<char, TrieNode2>();
        public bool EndOfWord = false;
    }
    public class Trie2
    {
        TrieNode2 root = null;
        public Trie2()
        {
            root = new TrieNode2();
        }

        public void Insert(string word)
        {
            TrieNode2 cur = this.root;
            foreach (var item in word)
            {
                if (!cur.childerns.ContainsKey(item))
                    cur.childerns.Add(item, new TrieNode2());
                cur = cur.childerns[item];
            }
            cur.EndOfWord = true;
        }

        public bool Search(string word)
        {
            TrieNode2 cur = this.root;
            foreach (var item in word)
            {
                if (!cur.childerns.ContainsKey(item))
                    return false;
                cur = cur.childerns[item];
            }
            return cur.EndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode2 cur = this.root;
            foreach (var item in prefix)
            {
                if (!cur.childerns.ContainsKey(item))
                    return false;
                cur = cur.childerns[item];
            }
            return true;
        }
    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */

}