using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    /// Definition for a binary tree node.
    // public class TreeNode
    // {
    //     public int val;
    //     public TreeNode left;
    //     public TreeNode right;
    //     public TreeNode(int x) { val = x; }
    // }

    /// <summary>
    /// #235
    /// root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
    /// Find the commant parent
    /// </summary>
    public static class LowestCommonAncestor
    {
        public static TreeNode Solution(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val < root.val && q.val < root.val)
            {
                return Solution(root.left, p, q);
            }
            else if (p.val > root.val && q.val > root.val)
            {
                return Solution(root.right, p, q);
            }
            return root;
        }
    }

    public class BinaryTree
    {
        public TreeNode root;

        public BinaryTree(int?[] arr)
        {
            root = ConvertToBinaryTree(arr, 0);
        }

        private TreeNode ConvertToBinaryTree(int?[] arr, int index)
        {

            if (index >= arr.Length || arr[index] == -1)
            {
                return null;
            }
            if (!arr[index].HasValue)
                return null;
            TreeNode node = new TreeNode(arr[index]);
            node.left = ConvertToBinaryTree(arr, 2 * index + 1);
            node.right = ConvertToBinaryTree(arr, 2 * index + 2);

            return node;
        }

        public void InOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.left);
                System.Diagnostics.Debug.Write(node.val + " ");
                InOrderTraversal(node.right);
            }
        }
    }
}