using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class GasStation
    {
        public int CanCompleteCircuit2(int[] gas, int[] cost)
        {
            if ((gas.Sum() - cost.Sum()) < 0)
                return -1;
            int res = 0;
            int total = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                total = total + gas[i] - cost[i];
                if (total < 0)
                {
                    res = i + 1;
                    total = 0;
                }
            }
            return res;
        }


        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            // int res = 0;
            List<(int, int)> idxOfgas = new List<(int, int)>();
            for (int i = 0; i < gas.Length; i++)
            {
                int lessGas = gas[i] - cost[i];
                if (lessGas >= 0)
                    idxOfgas.Add(new(i, lessGas));
            }
            idxOfgas = idxOfgas.OrderBy(x => x.Item2).ToList();

            foreach (var item in idxOfgas)
            {
                bool canTravel = this.TravelArround(gas, cost, item.Item1);
                if (canTravel)
                    return item.Item1;
            }
            return -1;
        }
        private bool TravelArround(int[] gas, int[] cost, int startIdx)
        {
            int len = gas.Length;
            int counter = 0;
            int lessGas = 0;

            while (counter < len)
            {
                if (startIdx >= len)
                    startIdx = 0;
                lessGas = gas[startIdx] - cost[startIdx] + lessGas;
                if (lessGas < 0)
                    return false;

                startIdx++;
                counter++;
            }
            return true;
        }
    }
}