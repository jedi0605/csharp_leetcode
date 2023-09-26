using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class DoubleNode
    {
        public DoubleNode(int key, int val)
        {
            this.key = key;
            this.value = val;
        }
        public int key;
        public int value;
        public DoubleNode pre;
        public DoubleNode next;
    }

    public class LRUCache
    {
        private Dictionary<int, DoubleNode> maps = null;
        private int capacity = 0;
        private DoubleNode HEAD;
        private DoubleNode TAIL;
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            maps = new Dictionary<int, DoubleNode>();
            HEAD = new DoubleNode(0, 0);
            TAIL = new DoubleNode(0, 0);
            HEAD.next = TAIL;
            TAIL.pre = HEAD;
        }
/// <summary>
/// Head <-> Val <-> TAIL
/// Remove from head, add from TAIL 
/// using double linked list or List<int> to opreate least use status.
/// </summary>
/// <param name="key"></param>
/// <returns></returns> <summary>
/// 
/// </summary>
/// <param name="key"></param>
/// <returns></returns>
        public int Get(int key)
        {
            if (maps.ContainsKey(key))
            {
                int res = maps[key].value;
                RemoveFromList(maps[key]);
                InsertToList(maps[key]);
                return res;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (maps.ContainsKey(key))
            {
                // Remove from tail.
                RemoveFromList(maps[key]);
                maps[key] = new DoubleNode(key, value);
                InsertToList(maps[key]);
            }

            else
            {
                if (maps.Count >= this.capacity)
                {
                    // add
                    DoubleNode newNode = new DoubleNode(key, value);
                    maps.Add(key, newNode);
                    InsertToList(newNode);
                    // remove
                    DoubleNode lruNode = HEAD.next;
                    RemoveFromList(lruNode);
                    maps.Remove(lruNode.key);
                }
                else
                {
                    DoubleNode newNode = new DoubleNode(key, value);
                    maps.Add(key, newNode);
                    InsertToList(newNode);
                }
            }
        }

        private void InsertToList(DoubleNode node)
        {
            var beforeTail = TAIL.pre;

            TAIL.pre = node;
            node.next = TAIL;
            node.pre = beforeTail;
            beforeTail.next = node;
        }

        private void RemoveFromList(DoubleNode node)
        {
            var nextNode = node.next;
            var preNode = node.pre;

            nextNode.pre = preNode;
            preNode.next = nextNode;
        }


    }
}