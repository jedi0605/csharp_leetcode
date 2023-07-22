using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class WordSearch
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
            //  

            // First step is to find first char. in board. (n is total board size)
            // Then we do DFS search.
            // O(n * m * 4)
            int rows = board.Length;
            int cols = board[0].Length;
            var visited = new bool[rows, cols];
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (_dfs(board, word, i, j, 0, visited))
                        return true;
                }
            }
            return false;
        }

        private bool _dfs(char[][] board, string word, int x, int y, int index, bool[,] visited)
        {
            if (x < 0 || x >= board.Length || y < 0 || y >= board[0].Length ||
                 visited[x, y] || board[x][y] != word[index])
            {
                System.Diagnostics.Debug.WriteLine("Remove:" + word[index] + "[" + x + "," + y + "]");
                return false;
            }
            if (index == word.Length - 1)
                return true;

            bool result = false;
            visited[x, y] = true;
            result |= _dfs(board, word, x + 1, y, index + 1, visited);
            result |= _dfs(board, word, x - 1, y, index + 1, visited);
            result |= _dfs(board, word, x, y + 1, index + 1, visited);
            result |= _dfs(board, word, x, y - 1, index + 1, visited);
            visited[x, y] = false;
            return result;
        }
    }
}