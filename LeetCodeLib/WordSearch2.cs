using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class WordSearch2
    {
        /// <summary>
        /// Complexity of iterative calls = O(nm)
        /// Complexity of dfs = 4^n
        /// O(nm*4^n)
        /// </summary>
        /// <param name="board"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool Exist(char[][] board, string word)
        {
            // First step is to find first char. in board. (n is total board size)
            // Then we do DFS search.
            // O(n * m * 4)
            int ROWS = board.Length;
            int COLS = board[0].Length;
            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLS; c++)
                {
                    if (dfs(r, c, board, 0, word))
                        return true;
                }
            }
            return false;
        }

        private bool dfs(int r, int c, char[][] board, int idx, string word)
        {
            if (r < 0 || c < 0 || r == board.Length || c == board[0].Length || board[r][c] != word[idx])
                return false;

            if (idx == word.Length - 1)
                return true;
            char tmp = board[r][c];
            board[r][c] = '.';
            bool res = this.dfs(r + 1, c, board, idx + 1, word) ||
                        this.dfs(r - 1, c, board, idx + 1, word) ||
                        this.dfs(r, c + 1, board, idx + 1, word) ||
                        this.dfs(r, c - 1, board, idx + 1, word);
            board[r][c] = tmp;
            return res;
        }
    }
}