using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class RandomizedSet
    {
        HashSet<int> sets { get; set; }
        List<int> currentVals { get; set; }
        public RandomizedSet()
        {
            this.sets = new HashSet<int>();
            this.currentVals = new List<int>();
        }

        public bool Insert(int val)
        {
            bool res = this.sets.Add(val);
            if (res)
                currentVals.Add(val);

            return res;
        }

        public bool Remove(int val)
        {
            bool res = this.sets.Remove(val);
            if (res)
                currentVals.Remove(val);
            return res;
        }

        public int GetRandom()
        {
            Random rnd = new Random();
            int r = rnd.Next(0, currentVals.Count);
            return currentVals[r];
        }
    }
}