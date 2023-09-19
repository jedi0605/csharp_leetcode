using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class TaskScheduler
    {
        /// <summary>
        /// tasks = ["A","A","A","B","B","B"], n = 2
        /// </summary>
        /// <param name="tasks"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int LeastInterval(char[] tasks, int n)
        {
            int[] tasksCount = new int[26];
            foreach (var item in tasks)
            {
                tasksCount[item - 'A']++;
            }

            int maxCount = 0;
            int maxCountSame = 0;
            for (int i = 0; i < tasksCount.Length; i++)
            {
                if (tasksCount[i] > maxCount)
                {
                    maxCount = tasksCount[i];
                    maxCountSame = 1;
                }
                else if (tasksCount[i] == maxCount)
                {
                    maxCountSame += 1;
                }
            }
            // A _ _ A _ _ 
            // Every loop will be n + A == n + 1
            // in the end no more need whole interval n 
            // so it will be maxCount - 1 like A B _ A B _ A
            // last maxCountSame is count for the end of scheduler if A and B are same mount
            int res = (n + 1) * (maxCount - 1) + maxCountSame;

            // pick bigger one.
            return Math.Max(res, tasks.Length);
        }
    }
}