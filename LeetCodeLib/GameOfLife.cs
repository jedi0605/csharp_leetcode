using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class GameOfLife
    {
        /// <summary>
        /// 
        /// 1 -> live if nei == 2,3 else die
        /// 0 -> live if nei == 3 else die

        /// Original | New | State
        ///    0       0      0
        ///    1       0      1
        ///    0       1      2
        ///    1       1      3         
        /// </summary>
        /// <param name="board"></param>
        public static void GameLife2(int[][] board)
        {
            int ROW = board.Length;
            int COL = board[0].Length;

            for (int r = 0; r < ROW; r++)
            {
                for (int c = 0; c < COL; c++)
                {
                    int nei = CountNeighbors2(board, r, c);
                    if (board[r][c] == 0 && nei == 3)
                    {
                        board[r][c] = 2;
                    }
                    if (board[r][c] == 1)
                    {
                        if (nei == 2 || nei == 3)
                            board[r][c] = 3;
                        else
                            board[r][c] = 1;
                    }
                }
            }
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    if (board[i][j] == 1)
                        board[i][j] = 0;
                    if (board[i][j] == 2)
                        board[i][j] = 1;
                    if (board[i][j] == 3)
                        board[i][j] = 1;
                }
            }
        }

        private static int CountNeighbors2(int[][] board, int r, int c)
        {
            // Count 8 dir.
            int ROW = board.Length;
            int COL = board[0].Length;
            int nei = 0;
            for (int i = r - 1; i < r + 2; i++)
            {
                for (int j = c - 1; j < c + 2; j++)
                {
                    if (i < 0 || j < 0 || i >= ROW || j >= COL || (i == r && j == c) == true)
                        continue;
                    if (board[i][j] == 1 || board[i][j] == 3)
                        nei++;
                }
            }
            return nei;
        }
        // public static void GameLife(int[][] board)
        // {
        //     int ROW = board.Length;
        //     int COL = board[0].Length;

        //     int[][] tmpBoard = new int[ROW][];
        //     for (int r = 0; r < ROW; r++)
        //     {
        //         tmpBoard[r] = new int[COL];
        //     }

        //     for (int r = 0; r < ROW; r++)
        //     {
        //         for (int c = 0; c < COL; c++)
        //         {
        //             int nei = CountNeighbors(board, r, c);
        //             if (board[r][c] == 0 && nei == 3)
        //             {
        //                 tmpBoard[r][c] = 1;
        //             }
        //             if (board[r][c] == 1)
        //             {
        //                 if (nei == 2 || nei == 3)
        //                     tmpBoard[r][c] = 1;
        //             }
        //         }
        //     }
        //     // tmpBoard over write to board.
        // }

    }
}