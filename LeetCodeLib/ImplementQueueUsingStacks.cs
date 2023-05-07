using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class ImplementQueueUsingStacks
    {
        private Stack<int> s1 = new();
        private Stack<int> s2 = new();

        public void Push(int x)
        {
            s1.Push(x);
        }

        public int Pop()
        {
            Rewind();
            return s2.Pop();
        }

        public int Peek()
        {
            Rewind();
            return s2.Peek();
        }

        public bool Empty()
        {
            return s1.Count < 1 && s2.Count < 1;
        }

        private void Rewind()
        {
            if (s2.Count < 1)
            {
                while (s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                }
            }
        }
    }
}