using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class WordSearchII
    {
        private HashSet<string> res = new HashSet<string>();
        private HashSet<(int, int)> visited = new HashSet<(int, int)>();
        private class TrieNode
        {
            public Dictionary<char, TrieNode> children;
            public bool WordEnd = false;
            public TrieNode()
            {
                this.children = new Dictionary<char, TrieNode>();
                this.WordEnd = false;
            }

            public void AddWord(string word)
            {
                TrieNode cur = this;
                for (int i = 0; i < word.Length; i++)
                {
                    if (!cur.children.ContainsKey(word[i]))
                        cur.children.Add(word[i], new TrieNode());
                    cur = cur.children[word[i]];
                }
                cur.WordEnd = true;
            }
        }

        /// <summary>
        /// Leetcode 212. Word Search II
        /// Complexity of dfs = 4^n
        /// O(n*m*4^word_len)
        /// Using Trie to cut down the search time
        public IList<string> FindWords(char[][] board, string[] words)
        {
            if (words.Length == 0) return new List<string>();
            TrieNode root = new TrieNode();
            foreach (var item in words)
                root.AddWord(item);

            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[0].Length; c++)
                {
                    if (root.children.ContainsKey(board[r][c]))
                    {
                        this.dfs(r, c, board, root, "");
                    }
                }
            }

            return new List<string>(res);
        }

        private void dfs(int r, int c, char[][] board, TrieNode root, string v)
        {
            if (r < 0 || c < 0 || r == board.Length || c == board[0].Length ||
            this.visited.Contains((r, c)) ||
            root.children.ContainsKey(board[r][c]) == false)
                return;
            this.visited.Add((r, c));

            root = root.children[board[r][c]];
            v += board[r][c];
            if (root.WordEnd)
                this.res.Add(v);
            this.dfs(r + 1, c, board, root, v);
            this.dfs(r - 1, c, board, root, v);
            this.dfs(r, c + 1, board, root, v);
            this.dfs(r, c - 1, board, root, v);

            this.visited.Remove((r, c));
        }
    }
}