using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class TestCase1
    {
        public int AddSum(int a, int b)
        {
            return a + b;
        }

        public int AddThree(int a, int b, int c)
        {
            return a + b + c;    
        }

        public string WeekenDay(int day)
        {
            string[] week = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
            return week[day];        
        }        
    }
}