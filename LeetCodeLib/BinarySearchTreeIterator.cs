using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel;

namespace LeetCodeLib
{
    /// <summary>
    /// LeetCode 173. Binary Search Tree Iterator
    /// 1. Stack approach. add root, going left as far as we can. When next(), 
    /// check right side have value or not. and go left side again.
    /// 
    /// 2. Init, add inorder to queue in constructer then dequeue, check count >0
    /// </summary>
    /// 

    public class BSTIterator
    {
        private Queue<int> arr;
        private int count = -1;
        public BSTIterator(TreeNode root)
        {
            arr = new Queue<int>();
            init(root);
        }
        private void init(TreeNode root)
        {
            if (root == null) return;
            init(root.left);
            arr.Enqueue(root.val.Value);
            init(root.right);
        }
        public int Next()
        {
            return this.arr.Dequeue();
        }

        public bool HasNext()
        {
            return this.arr.Count > 0;
        }
    }
}


// private Stack<TreeNode> stack = new Stack<TreeNode>();
//         public BSTIterator(TreeNode root)
//         {
//             this.stack.Push(root);
//             while (root.left != null)
//             {
//                 this.stack.Push(root.left);
//                 root = root.left;
//             }
//         }

//         public int Next()
//         {
//             var res = this.stack.Pop();
//             var cur = res.right;
//             while (cur != null)
//             {
//                 this.stack.Push(cur);
//                 cur = cur.left;
//             }

//             return res.val.Value;
//         }

//         public bool HasNext()
//         {
//             return stack.Count > 0;
//         }