using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class CourseScheduleII
    {
        /// <summary>
        /// Leetcode 210. Course ScheduleII
        /// test case will be
        /// [[1,0],[2,0],[3,1],[3,2]]
        /// </summary>
        /// <param name="numCourses"></param>
        /// <param name="prerequisites"></param>
        /// <returns></returns>
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            List<int> res = new List<int>();
            // 0    1   2   3
            //[0    1   1   2]
            int[] indegree = new int[numCourses];
            //{0:[1,2], 1:[3],2:[3],3:[]}            
            Dictionary<int, List<int>> maps = new Dictionary<int, List<int>>();
            for (int i = 0; i < numCourses; i++)
                maps[i] = new List<int>();
            for (int i = 0; i < prerequisites.Length; i++)
            {
                int first = prerequisites[i][0];
                int sec = prerequisites[i][1];
                maps[sec].Add(first);
                indegree[first]++;
            }


            Queue<int> q = new Queue<int>();
            for (int i = 0; i < numCourses; i++)
            {
                if (indegree[i] == 0)
                    q.Enqueue(i);
            }
            int visited = 0;
            while (q.Any())
            {
                int cur = q.Dequeue();
                res.Add(cur);
                visited++;
                foreach (var item in maps[cur])
                {
                    indegree[item]--;
                    if (indegree[item] == 0)
                        q.Enqueue(item);
                }
            }

            return visited == numCourses ? res.ToArray() : new int[] { };
        }
    }
}