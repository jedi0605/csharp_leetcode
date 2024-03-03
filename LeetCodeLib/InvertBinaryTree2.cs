using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{

    /// <summary>
    /// 226. Invert Binary Tree
    /// 1. maps<int,DoubleNode> -> get val in O(1)
    /// 2. LeftNode, RightNode -> track the LeastNode, RecentNode
    /// 3. Remove(DoubleNode). Remove Node
    /// 4. Insert(DoubleNode). InsertNode to the right.
    /// #Leetcode 150    
    /// O(n)
    /// O(n)
    /// </summary>
    public static class InvertBinaryTree2
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            // Base Case
            if (root == null)
                return root;

            // Swaps nodes 
            TreeNode tempNode = root.left;
            root.left = root.right;
            root.right = tempNode;

            // Can not put return on recursive tree calls
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }
    }
}