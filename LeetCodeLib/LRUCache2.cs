using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class DoubleNode2
    {
        public int key;
        public int val;
        public DoubleNode2 prev;
        public DoubleNode2 next;

        public DoubleNode2(int key, int val)
        {
            this.key = key;
            this.val = val;
            this.prev = null;
            this.next = null;
        }
    }
    /// <summary>
    /// 1. maps<int,DoubleNode> -> get val in O(1)
    /// 2. LeftNode, RightNode -> track the LeastNode, RecentNode
    /// 3. Remove(DoubleNode). Remove Node
    /// 4. Insert(DoubleNode). InsertNode to the right.
    /// </summary>
    public class LRUCache2
    {
        int capacity = 0;
        Dictionary<int, DoubleNode2> maps = new Dictionary<int, DoubleNode2>();
        DoubleNode2 LeftNode = null;
        DoubleNode2 RightNode = null;
        public LRUCache2(int capacity)
        {
            this.capacity = capacity;
            this.LeftNode = new DoubleNode2(0, 0);
            this.RightNode = new DoubleNode2(0, 0);
            this.LeftNode.next = this.RightNode;
            this.RightNode.prev = this.LeftNode;
        }
        public void PrintList()
        {
            DoubleNode2 dum = this.LeftNode;
            while (dum != null)
            {
                System.Diagnostics.Debug.Write(dum.val);
                dum = dum.next;
            }
        }
        public void Remove(DoubleNode2 node)
        {
            DoubleNode2 preNode = node.prev;
            DoubleNode2 nextNode = node.next;
            preNode.next = nextNode;
            nextNode.prev = preNode;
        }

        // alway add to the right
        public void Insert(DoubleNode2 node)
        {
            DoubleNode2 preNode = this.RightNode.prev;
            preNode.next = node;
            this.RightNode.prev = node;

            node.prev = preNode;
            node.next = this.RightNode;
        }

        public int Get(int key)
        {
            if (maps.ContainsKey(key))
            {
                DoubleNode2 tmp = maps[key];
                // remove
                this.Remove(tmp);
                // insert. Cuz we want to move node to the Recent
                this.Insert(tmp);
                return maps[key].val;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (maps.ContainsKey(key))
                this.Remove(maps[key]);

            DoubleNode2 newNode = new DoubleNode2(key, value);
            this.Insert(newNode);
            maps[key] = newNode;
            if (maps.Count > this.capacity) // remove node            
            {
                DoubleNode2 removeN = this.LeftNode.next;
                this.Remove(removeN);
                maps.Remove(removeN.key);
            }
        }

    }
}