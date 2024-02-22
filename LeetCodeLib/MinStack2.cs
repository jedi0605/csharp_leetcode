using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// <summary>
    /// Leetcode 155. Min Stack
    /// Using two stack to imprement get smellest val in O(1)
    /// _stack -> normal stack
    /// _minStack -> Every time when excute Push func will comapare the current 
    ///              val and _minStack.peek() get smellest one and add to _minStack
    ///              in the SAME time. It's a easy way to operate Pop func
    /// #Leetcode 150
    /// #Stack
    /// O(1)
    /// O(n)
    public class MinStack2
    {
        private Stack<int> _stack = null;
        private Stack<int> _minStack = null;
        public MinStack2()
        {
            _stack = new();
            _minStack = new();
        }

        public void Push(int val)
        {
            _stack.Push(val);
            int min = val;
            if (_minStack.Count != 0)
                min = Math.Min(_minStack.Peek(), val);
            _minStack.Push(min);
        }

        public void Pop()
        {
            _stack.Pop();
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