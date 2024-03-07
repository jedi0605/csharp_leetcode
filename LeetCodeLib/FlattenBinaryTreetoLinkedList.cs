using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata.Ecma335;

namespace LeetCodeLib
{
    /// <summary>
    /// LeetCode 114. Flatten Binary Tree to Linked List
    /// 1.DFS Stack to track.
    /// 2.Using while. find sub tree's right most node.
    /// </summary>
    /// 

    public static class FlattenBinaryTreetoLinkedList
    {
        public static void Flatten(TreeNode root)
        {
            TreeNode curr = root;
            while (curr != null)
            {
                if (curr.left != null) // find the most right node
                {
                    TreeNode nxtL = curr.left;
                    while (nxtL.right != null)
                        nxtL = nxtL.right;
                    nxtL.right = curr.right;
                    curr.right = curr.left;
                    curr.left = null;
                }
                curr = curr.right;
            }
        }
        // public static void Flatten(TreeNode root)
        // {
        //     Stack<TreeNode> stack = new Stack<TreeNode>();
        //     stack.Push(root);
        //     while (stack.Count > 0)
        //     {
        //         int count = stack.Count;
        //         for (int i = 0; i < count; i++)
        //         {
        //             TreeNode treeNode = stack.Pop();
        //             if (treeNode.right != null)
        //                 stack.Push(treeNode.right);
        //             if (treeNode.left != null)
        //                 stack.Push(treeNode.left);
        //             if (stack.Count > 0)
        //                 treeNode.right = stack.Peek();
        //             treeNode.left = null;
        //         }
        //     }
        // }
    }
}