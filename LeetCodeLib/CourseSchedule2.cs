using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class CourseSchedule2
    {
        /// <summary>
        /// test case will be
        /// [2,0]
        /// [2,1]
        /// [4,2]
        /// [4,3]
        /// </summary>
        /// <param name="numCourses"></param>
        /// <param name="prerequisites"></param>
        /// <returns></returns>
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            int[] indegree = new int[numCourses];
            //  0  1  2  3  4
            // [0, 0, 2, 0, 1]
            Dictionary<int, List<int>> maps = new Dictionary<int, List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                maps[i] = new List<int>();
            }
            // {0, [2]}
            // {1, [2]}
            // {2, [4]}
            // {3, [4]}
            // {4, []}
            for (int i = 0; i < prerequisites.Length; i++)
            {
                // [2,0]
                indegree[prerequisites[i][0]]++;
                maps[prerequisites[i][1]].Add(prerequisites[i][0]);
            }
            Queue<int> q = new Queue<int>();
            // q = [0 ,1 ,3]
            for (int i = 0; i < indegree.Length; i++)
            {
                if (indegree[i] == 0)
                    q.Enqueue(i);
            }
            int visited = 0;
            while (q.Any())
            {
                int cur = q.Dequeue();
                visited++;
                for (int i = 0; i < maps[cur].Count; i++)
                {
                    indegree[maps[cur][i]]--;
                    if (indegree[maps[cur][i]] == 0)
                        q.Enqueue(maps[cur][i]);
                }
            }
            return visited == numCourses;
        }

    }
}