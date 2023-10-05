using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class ValidSudoku
    {
        public ValidSudoku()
        {

        }
        public bool IsValidSudoku(char[][] board)
        {
            HashSet<char>[] rowSet = new HashSet<char>[9];
            HashSet<char>[] colSet = new HashSet<char>[9];
            // init HashSet
            for (int i = 0; i < 9; i++)
            {
                rowSet[i] = new HashSet<char>();
                colSet[i] = new HashSet<char>();
            }

            HashSet<char>[,] box = new HashSet<char>[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    box[i, j] = new HashSet<char>();
                }
            }

            // check row;
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row][col] == '.')
                        continue;
                    if (rowSet[row].Add(board[row][col]) == false)
                        return false;
                    if (colSet[col].Add(board[row][col]) == false)
                        return false;
                    if (box[row / 3, col / 3].Add(board[row][col]) == false)
                        return false;
                }
            }
            // check col;        
            return true;
        }
    }
}