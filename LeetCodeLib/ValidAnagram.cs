using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class ValidAnagram
    {

        public static bool IsAnagram(string s, string t)
        {
            try
            {
                Dictionary<char, int> checkTable = new Dictionary<char, int>();
                foreach (var item in s)
                {
                    if (!checkTable.ContainsKey(item))
                        checkTable.Add(item, 1);
                    else
                        checkTable[item] = checkTable[item] + 1;
                }

                foreach (var item in t)
                {
                    if (!checkTable.ContainsKey(item))
                        return false;
                    else
                        checkTable[item] = checkTable[item] - 1;
                }

                System.Diagnostics.Debug.WriteLine(checkTable.Sum(x => x.Value));
                return checkTable.Where(x => x.Value > 0).Count() == 0 ? true : false;
            }
            catch (System.Exception)
            {
                return false;
            }

        }
    }
}