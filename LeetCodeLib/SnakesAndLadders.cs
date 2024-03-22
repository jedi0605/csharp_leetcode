using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class SnakesAndLadders
    {
        public int Steps(int[][] board)
        {
            int[][] rBoard = board.Reverse().ToArray();

            int len = board.Length;
            HashSet<int> visted = new HashSet<int>();
            Queue<(int, int)> q = new Queue<(int, int)>();
            q.Enqueue((1, 0));

            while (q.Any())
            {
                (int square, int move) = q.Dequeue();

                for (int i = 1; i < 7; i++)
                {
                    int newSquare = square + i;                   
                    int[] rowCol = intToSquare(newSquare, len);
                    if (rBoard[rowCol[0]][rowCol[1]] != -1)
                        newSquare = rBoard[rowCol[0]][rowCol[1]];
                    if (newSquare == len * len)
                        return move + 1;
                    if (!visted.Contains(newSquare))
                    {
                        visted.Add(newSquare);
                        q.Enqueue((newSquare, move + 1));
                    }
                }
            }
            return -1;
        }
        public int[] intToSquare(int step, int len)
        {
            int row = (step - 1) / len;
            int col = (step - 1) % len;
            if (row % 2 == 1)
                col = len - col - 1;
            int[] rowCol = new int[] { row, col };
            return rowCol;
        }
    }
}