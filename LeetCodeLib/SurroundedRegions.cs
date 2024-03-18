using System;
using System.Collections.Generic;
using System.Data;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 130. Surrounded Regions
    /// In this question. Not surround regions MUST connect to the edge.
    /// 1.Find "O" element on edge. Do DFS mark all connect element to "T"
    /// 2.For loop all board. O->X
    /// 3.T -> O
    /// </summary>
    /// 
    public class SurroundedRegions
    {
        private int ROWS = 0;
        private int COLS = 0;
        public void Solve(char[][] board)
        {
            this.ROWS = board.Length;
            this.COLS = board[0].Length;
            // Part1 Find O element on edge.
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    if ((i == 0 || i == ROWS - 1 || j == 0 || j == COLS - 1) && board[i][j] == 'O')
                        this.DfsHelper(i, j, board);
                }
            }
            // Part2
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    if (board[i][j] == 'O')
                        board[i][j] = 'X';
                }
            }
            // Part3
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    if (board[i][j] == 'T')
                        board[i][j] = 'O';
                }
            }
        }
        private void DfsHelper(int r, int c, char[][] board)
        {
            if (r < 0 || r == this.ROWS || c < 0 || c == this.COLS || board[r][c] != 'O')
                return;
            board[r][c] = 'T';
            DfsHelper(r + 1, c, board);
            DfsHelper(r - 1, c, board);
            DfsHelper(r, c + 1, board);
            DfsHelper(r, c - 1, board);
        }
    }
}