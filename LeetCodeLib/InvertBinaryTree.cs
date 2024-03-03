using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class TreeNode
    {
        public int? val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int? val, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static TreeNode ArrToTree(int[]? arr, int index = 0)
        {
            if (index < arr.Length)
            {
                if (arr[index] == null)
                    return null;
                TreeNode treeNode = new TreeNode(arr[index]);
                treeNode.left = ArrToTree(arr, index * 2 + 1);
                treeNode.right = ArrToTree(arr, index * 2 + 2);
                return treeNode;
            }
            return null;
        }

        public static bool CompareTrees(TreeNode tree1, TreeNode tree2)
        {
            if (tree1 == null && tree2 == null)
                return true;

            if (tree1 == null || tree2 == null)
                return false;

            if (tree1.val != tree2.val)
                return false;

            if (CompareTrees(tree1.left, tree2.left) == false)
                return false;

            if (CompareTrees(tree1.right, tree2.right) == false)
                return false;

            return true;
        }
    }


    /// <summary>
    /// Using DFS to revert 
    /// </summary>
    public static class InvertBinaryTree
    {
        public static TreeNode InvertTree(TreeNode root)
        {


            if (root == null)
            {
                return null;
            }

            var left = root.left;
            var right = root.right;
            root.left = InvertTree(right);
            root.right = InvertTree(left);

            return root;
        }

        public static void PrintAll(TreeNode root)
        {
            if (root == null)
                return;

            System.Diagnostics.Debug.WriteLine(root.val);
            PrintAll(root.left);
            PrintAll(root.right);
        }

        public static bool CompareTrees(TreeNode tree1, TreeNode tree2)
        {
            if (tree1 == null && tree2 == null)
                return true;

            if (tree1 == null || tree2 == null)
                return false;

            if (tree1.val != tree2.val)
                return false;

            if (CompareTrees(tree1.left, tree2.left) == false)
                return false;

            if (CompareTrees(tree1.right, tree2.right) == false)
                return false;

            return true;
        }
    }
}