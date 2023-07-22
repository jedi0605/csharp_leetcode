using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class FindAllAnagramsInAString
    {
        /// <summary>
        /// Time complexity:O(N*M)
        /// Space complexity:O(N+N) 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public IList<int> FindAnagrams(string s, string p)
        {
            //s' HashMap and compare p Hashmap;
            //if s' == p > add index[i] to result.
            // Sliding window approach
            int[] sArray = new int[26];
            int[] pArray = new int[26];
            for (int i = 0; i < p.Length; i++)
            {
                sArray[s[i] - 'a']++; // sliding window init.
                pArray[p[i] - 'a']++;
            }

            List<int> result = new List<int>();

            for (int i = 0; i < s.Length - p.Length; i++)
            {
                if (IsSameArray(sArray, pArray))
                    result.Add(i);
                sArray[s[i] - 'a']--;
                sArray[s[i + p.Length] - 'a']++; // remember check the last one case.
            }

            if (IsSameArray(sArray, pArray))
                result.Add(s.Length - p.Length);

            return result;

            // List<string> coms = new List<string>();

            // char[] buffer = new char[p.Length];
            // bool[] used = new bool[p.Length];

            // CombinationHelper(p, buffer, used, 0, coms);

            // // brute force
            // // List all combination of p => List m
            // // loop s to find  index of each m combination.
            // HashSet<int> ans = new HashSet<int>();
            // // Stack<char> stack = new Stack<char>();
            // // allPcombination(p, stack, coms);

            // // Find match index
            // foreach (var item in coms)
            // {
            //     // i is start index.
            //     for (int i = 0; i < s.Length; i++)
            //     {
            //         if ((i + item.Length) > s.Length)
            //             break;
            //         string subString = s.Substring(i, item.Length);
            //         if (subString == item)
            //             ans.Add(i);
            //     }
            // }
            // return ans.ToList();
        }

        private bool IsSameArray(int[] sArray, int[] pArray)
        {
            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i] != pArray[i])
                    return false;
            }
            return true;
        }

        static void CombinationHelper(string input, char[] buffer, bool[] used, int position, List<string> ress)
        {
            if (position == input.Length)
            {
                Console.WriteLine(new string(buffer));
                ress.Add(new string(buffer));
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (!used[i])
                {
                    buffer[position] = input[i];
                    used[i] = true;
                    CombinationHelper(input, buffer, used, position + 1, ress);
                    used[i] = false;
                }
            }
        }

        /// <summary>
        /// O(n!)  only work in non-duplicate p input
        /// </summary>
        /// <param name="p"></param>
        /// <param name="stack"></param>
        /// <param name="res"></param>
        private void allPcombination(string p, Stack<char> stack, List<string> res)
        {
            if (stack.Count == p.Length)
                res.Add(new string(stack.ToArray()));
            for (int i = 0; i < p.Length; i++)
            {
                if (!stack.Contains(p[i]))
                {
                    stack.Push(p[i]);
                    allPcombination(p, stack, res);
                    stack.Pop();
                }
            }
        }


        // private void AddCombination(string curr, string digits, int index, IList<string> res)
        // {
        //     if (curr.Length == digits.Length)
        //     {
        //         res.Add(curr);
        //     }
        //     else
        //     {
        //         char[] map = keypad[digits[index]];
        //         for (int i = 0; i < map.Length; i++)
        //         {
        //             string newCurr = curr + map[i];
        //             AddCombination(newCurr, digits, index + 1, res);
        //         }
        //     }
        // }
    }
}