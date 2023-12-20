using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class SubstringWithConcatenationOfAllWords
    {
        public static IList<int> FindSubstring(string s, string[] words)
        {
            if (words.Length == 0) return new List<int>();
            int wordLen = words[0].Length;
            int totalLen = wordLen * words.Length;
            List<int> res = new List<int>();
            Dictionary<string, int> wordDic = new Dictionary<string, int>();

            foreach (var item in words)
            {
                wordDic[item] = 1 + wordDic.GetValueOrDefault(item, 0);
            }

            for (int i = 0; i < s.Length - totalLen + 1; i++)
            {
                int j = 0;
                Dictionary<string, int> tmpWord = new Dictionary<string, int>();

                while (j < totalLen)
                {
                    string subStr = s.Substring(i + j, wordLen);
                    if (wordDic.ContainsKey(subStr))
                    {
                        if (tmpWord.ContainsKey(subStr))
                            tmpWord[subStr]++;
                        else
                            tmpWord.Add(subStr, 1);
                        if (tmpWord[subStr] > wordDic[subStr])
                            break;
                    }

                    else
                        break;
                    j += wordLen;
                }

                if (j == totalLen)
                    res.Add(i);
            }
            return res;
        }

        public static List<string> ConcatenatedStrings(string[] words)
        {
            List<string> result = new List<string>();
            GenerateCombinations(words, new List<string>(), result);
            return result;
        }

        private static void GenerateCombinations(string[] words, List<string> current, List<string> result)
        {
            if (current.Count > 0)
            {
                result.Add(string.Join("", current));
            }
            if (current.Count == words.Length)
                return;

            foreach (string word in words)
            {
                List<string> newCurrent = new List<string>(current);
                newCurrent.Add(word);
                GenerateCombinations(words, newCurrent, result);
            }
        }
    }
}