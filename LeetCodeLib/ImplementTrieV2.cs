using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class TrieNode
    {
        internal bool isEnd;
        internal TrieNode[] children;
        char _val;
        public TrieNode(char val)
        {
            children = new TrieNode[26];
            _val = val;
        }
    }
    public class Trie
    {
        TrieNode root = null;
        public Trie()
        {
            root = new TrieNode('*');
        }

        public void Insert(string word)
        {
            TrieNode cur = root;
            for (int i = 0; i < word.Length; i++)
            {
                char curChar = word[i];
                if (cur.children[curChar - 'a'] == null)
                    cur.children[curChar - 'a'] = new TrieNode(curChar);
                cur = cur.children[curChar - 'a'];
            }
            cur.isEnd = true;
        }

        public bool Search(string word)
        {
            TrieNode cur = root;
            for (int i = 0; i < word.Length; i++)
            {
                char curChar = word[i];
                if (cur.children[curChar - 'a'] == null) return false;
                cur = cur.children[curChar - 'a'];
            }
            return cur.isEnd;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode cur = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                char curChar = prefix[i];
                if (cur.children[curChar - 'a'] == null) return false;
                cur = cur.children[curChar - 'a'];
            }
            return true;
        }
    }
}