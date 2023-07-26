using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class Keyboard
    {
        public static Dictionary<char, List<char>> GeneKeyMap(string keypad)
        {
            //indexMap = 
            Dictionary<int, List<int>> indexMap = new Dictionary<int, List<int>>();
            indexMap.Add(0, new List<int>() { 1, 3, 4 });
            indexMap.Add(1, new List<int>() { 0, 2, 3, 4, 5 });
            indexMap.Add(2, new List<int>() { 1, 4, 5 });
            indexMap.Add(3, new List<int>() { 0, 1, 4, 6, 7 });
            indexMap.Add(4, new List<int>() { 0, 1, 2, 3, 5, 6, 7, 8 });
            indexMap.Add(5, new List<int>() { 1, 2, 4, 7, 8 });
            indexMap.Add(6, new List<int>() { 3, 4, 7 });
            indexMap.Add(7, new List<int>() { 3, 4, 5, 6, 8 });
            indexMap.Add(8, new List<int>() { 4, 5, 7 });
            Dictionary<char, List<char>> maps = new Dictionary<char, List<char>>();

            for (int i = 0; i < keypad.Length; i++)
            {
                List<int> nextOneSecondIndex = indexMap[i];
                List<char> nextOneSecond = new List<char>();
                foreach (var item in nextOneSecondIndex)
                    nextOneSecond.Add(keypad[item]);

                maps.Add(keypad[i], nextOneSecond);
            }
            return maps;
        }

        public static int entryTime(string s, string keypad)
        {
            // Gene Keypad > using Dictionary<char, adjacentCharIndex>
            // 0 index will key1,key3,key4. Example 1 ajacentNum is 2,4,5
            if (string.IsNullOrEmpty(s) || s.Length == 0) return 0;
            Dictionary<char, List<char>> keyMap = GeneKeyMap(keypad);
            int totalSec = 0;
            char prevChar = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                char currChar = s[i];
                if (currChar == prevChar)
                    continue;
                if (keyMap[currChar].Contains(prevChar))
                    totalSec += 1;
                else
                    totalSec += 2;
                prevChar = currChar;
            }
            return totalSec;
            // And we using map for lookup(?)  
        }
    }
}