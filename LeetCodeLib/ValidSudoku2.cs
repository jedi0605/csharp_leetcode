using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class ValidSudoku2
    {
        public static bool IsValidSudoku(char[][] board)
        {
            HashSet<char>[] rows = new HashSet<char>[9];
            HashSet<char>[] cols = new HashSet<char>[9];
            for (int i = 0; i < 9; i++)
            {
                rows[i] = new HashSet<char>();
                cols[i] = new HashSet<char>();
            }

            HashSet<char>[,] squares = new HashSet<char>[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    squares[i, j] = new HashSet<char>();
                }
            }

            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    if (board[r][c] == '.')
                        continue;
                    if (rows[r].Contains(board[r][c]) ||
                        cols[c].Contains(board[r][c]) ||
                        squares[r/3,c/3].Contains(board[r][c]))
                        return false;
                    
                    rows[r].Add(board[r][c]);
                    cols[c].Add(board[r][c]);
                    squares[r/3,c/3].Add(board[r][c]);
                }
            }

            return true;
        }
    }
}