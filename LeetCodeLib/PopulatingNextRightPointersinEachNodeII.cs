using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata.Ecma335;

namespace LeetCodeLib
{
    /// <summary>
    /// LeetCode 117. Populating Next Right Pointers in Each Node II
    /// BFS search. two pointer pre, curr if pre!=null pre.next = curr
    /// </summary>
    /// 

    public class NodeNext
    {
        public int val;
        public NodeNext left;
        public NodeNext right;
        public NodeNext next;

        public NodeNext() { }

        public NodeNext(int _val)
        {
            val = _val;
        }

        public NodeNext(int _val, NodeNext _left, NodeNext _right, NodeNext _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }

        public static NodeNext ArrToTree(int?[] arr, int index = 0)
        {
            if (index < arr.Length)
            {
                if (arr[index] == null)
                    return null;
                NodeNext treeNode = new NodeNext(arr[index].Value);
                treeNode.left = ArrToTree(arr, index * 2 + 1);
                treeNode.right = ArrToTree(arr, index * 2 + 2);
                return treeNode;
            }
            return null;
        }
    }

    public static class PopulatingNextRightPointersinEachNodeII
    {
        public static NodeNext Connect(NodeNext root)
        {
            NodeNext dumm = root;
            Queue<NodeNext> q = new Queue<NodeNext>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                NodeNext pre = null;
                int qCount = q.Count;
                for (int i = 0; i < qCount; i++)
                {
                    NodeNext curr = q.Dequeue();
                    if (pre != null)
                        pre.next = curr;
                    pre = curr;
                    if (curr.left != null)
                        q.Enqueue(curr.left);
                    if (curr.right != null)
                        q.Enqueue(curr.right);
                }
            }
            return root;
        }
    }
}