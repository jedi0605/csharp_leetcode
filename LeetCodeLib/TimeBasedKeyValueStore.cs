using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class TimeMap
    {

        Dictionary<string, List<(int timestamp, string _value)>> _map;
        public TimeMap()
        {
            _map = new();
        }

        public void Set(string key, string value, int timestamp)
        {

            if (!_map.ContainsKey(key))
                _map[key] = new();
            _map[key].Add((timestamp, value));
        }

        public string Get(string key, int timestamp)
        {
            if (!_map.ContainsKey(key))
                return string.Empty;
            
            var list = _map[key];
            var left = 0;
            var right = list.Count - 1;
            var lastFound = "";

            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (list[mid].timestamp == timestamp)
                    return list[mid]._value;

                if (list[mid].timestamp <= timestamp)
                {
                    lastFound = list[mid]._value;
                    left = mid + 1;
                }
                else
                    right = mid - 1;
            }
            return lastFound;
        }
    }

}