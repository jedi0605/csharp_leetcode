using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class CourseSchedule
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
            if (prerequisites == null) return true;
            int[] inDegree = new int[numCourses];
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

            foreach (var item in prerequisites)
            {
                /// count how many inDegree. 
                /// Finally will be 
                ///  0 1 2 3 4
                /// [0,0,2,0,2]        
                inDegree[item[0]]++;

                /// We build
                /// [0 > 2]
                /// [1 > 2]
                /// [2 > 4]
                /// [3 > 4]            
                if (!map.ContainsKey(item[1]))
                    map.Add(item[1], new List<int>() { item[0] });
                else
                    map[item[1]].Add(item[0]);
            }
            Queue<int> q = new Queue<int>();
            // init Queue.
            for (int i = 0; i < inDegree.Length; i++)
            {
                if (inDegree[i] == 0)
                    q.Enqueue(i);
            }

            while (q.Count > 0)
            {
                int cur = q.Dequeue();
                List<int> curList = null;
                map.TryGetValue(cur, out curList);
                // ?? to avoid curList is null case.
                foreach (var item in curList ?? new List<int>()) 
                {
                    inDegree[item]--;
                    if (inDegree[item] == 0)
                        q.Enqueue(item);
                }
            }
            foreach (var item in inDegree)
            {
                if (item > 0)
                    return false;
            }
            return true;
        }

    }
}