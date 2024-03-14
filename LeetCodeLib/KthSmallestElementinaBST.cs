using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel;
using System.Transactions;

namespace LeetCodeLib
{
    /// <summary>
    /// LeetCode 230. Kth Smallest Element in a BST
    /// In BST tree. using inorder trevals will getting ordering array.
    /// Using Stack to implemente. counting pop times will get Kth smallest num.
    /// Count 
    /// </summary>

    public class KthSmallestElementinaBST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            if (root == null) return 0;
            int c = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            var curr = root;
            while (curr != null || stack.Count > 0)
            {
                while(curr!=null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                c++;
                if (c == k)
                    return curr.val.Value;
                curr = curr.right;
            }
            return 0;
        }
    }
}