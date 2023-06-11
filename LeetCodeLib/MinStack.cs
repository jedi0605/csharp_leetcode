using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class MinStack
    {
        private int _min = 0;
        private Stack<int> _stack = null;
        private Stack<int> _minStack = null;
        public MinStack()
        {
            _stack = new();
            _minStack = new();
        }

        public void Push(int val)
        {
            if (_minStack.Count == 0)
            {
                _minStack.Push(val);
            }
            else
            {
                // if  val < _minStack.Peek add, other skip 
                if (val <= _minStack.Peek())
                    _minStack.Push(val);
            }
            _stack.Push(val);
        }

        public void Pop()
        {

            int pop = _stack.Pop();
            if (pop == _minStack.Peek())
                _minStack.Pop();
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            return _minStack.Peek();
        }
    }
}