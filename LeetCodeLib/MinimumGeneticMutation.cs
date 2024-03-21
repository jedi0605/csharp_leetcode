using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class MinimumGeneticMutation
    {
        /// <summary>
        /// LeetCode 433. Minimum Genetic Mutation
        /// In BST tree. brute force create all possible new gene.
        /// Add to hashset or check with bank
        /// </summary>
        public int MinMutation(string startGene, string endGene, string[] bank)
        {
            HashSet<string> banksSet = new HashSet<string>(bank);
            HashSet<string> visited = new HashSet<string>();
            char[] options = new char[] { 'A', 'T', 'C', 'G' };

            Queue<(string, int)> q = new Queue<(string, int)>();
            q.Enqueue((startGene, 0));
            while (q.Any())
            {
                (string gene, int times) = q.Dequeue();
                if (gene == endGene)
                    return times;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        string startToI = gene.Substring(0, i);
                        string ItoEnd = gene.Substring(i + 1, 8 - i - 1);
                        string newGene = startToI + options[j] + ItoEnd;
                        if (visited.Contains(newGene) == false && banksSet.Contains(newGene))
                        {
                            q.Enqueue((newGene, times + 1));
                            visited.Add(newGene);
                        }
                    }
                }
            }
            return -1;
        }
    }
}