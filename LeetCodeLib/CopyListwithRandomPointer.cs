using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class Noder
    {
        public int val;
        public Noder next;
        public Noder random;

        public Noder(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

    /// <summary>
    /// Leetcode 138. Copy List with Random Pointer
    /// Careful with node.next, node.random pointer to null.
    /// #Leetcode 150
    /// #Stack
    /// O(n)
    /// O(n)
    public class CopyListwithRandomPointer
    {
        public Noder CopyRandomList(Noder head)
        {
            if (head == null) return null; // Edge case
            var curr = head;
            Dictionary<Noder, Noder> maps = new Dictionary<Noder, Noder>();

            while (curr != null)
            {
                Noder copy = new Noder(curr.val);
                maps[curr] = copy;
                curr = curr.next;
            }

            curr = head;
            while (curr != null)
            {
                Noder copy = maps[curr];
                // Carefult with null
                copy.next = curr.next == null ? null : maps[curr.next];
                copy.random = curr.random == null ? null : maps[curr.random]; ;
                curr = curr.next;
            }
            return maps[head];
        }
    }
}