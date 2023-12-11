using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class TextJustification
    {
        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> res = new List<string>();
            var curr = new List<string>();
            int numLetter = 0; // row length

            foreach (var item in words)
            {
                // justify curr ans
                if (item.Length + curr.Count + numLetter > maxWidth)
                {
                    int extraSpac = maxWidth - numLetter; // how many space left                    
                    int sapce = extraSpac / Math.Max(1, curr.Count - 1);
                    int remainder = extraSpac % Math.Max(1, curr.Count - 1);

                    // add space in between. or add in the end
                    for (int j = 0; j < Math.Max(1, curr.Count - 1); j++)
                    {
                        for (int sp = 0; sp < sapce; sp++)
                            curr[j] += " ";

                        if (remainder > 0)
                        {
                            curr[j] += " ";
                            remainder--;
                        }
                    }
                    res.Add(string.Join("", curr));
                    curr.Clear();
                    numLetter = 0;
                }
                curr.Add(item);
                numLetter += item.Length;

            }
            // Dealing with last line.            
            string last = string.Join(" ", curr);
            while (last.Length < maxWidth) last += " ";
            res.Add(last);

            return res;
        }
    }
}