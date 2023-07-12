using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace LeetCodeLib
{
    /// <summary>
    /// PreOrder > root node always be first.
    /// preorder: root > left > right
    ///
    /// InOrder > always traversal the leftest side.
    /// inorder: left > root > right
    /// </summary>
    public static class ConstructBinaryTreeFromPreorderAndInorderTraversal
    {
        /// <summary>
        /// Better performance. EZ understanding.
        /// 
        /// </summary>
        /// <param name="preorder"></param>
        /// <param name="inorder"></param>
        /// <returns></returns>
        public static TreeNode BuildTreeV2(int[] preorder, int[] inorder)
        {
            if (inorder.Length == 0) return null;
            Dictionary<int, int> maps = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                maps.Add(inorder[i], i);
            }
            return Build(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1, maps);
        }

        private static TreeNode Build(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd, Dictionary<int, int> maps)
        {
            if (inStart > inEnd || preStart > preEnd) return null;

            var root = new TreeNode(preorder[preStart]);
            int inorderRootIndex = maps[root.val.Value];
            int numsOfLeft = inorderRootIndex - inStart;

            root.left = Build(preorder, preStart + 1, preStart + numsOfLeft, inorder, inStart, inorderRootIndex - 1, maps);
            root.right = Build(preorder, preStart + numsOfLeft + 1, preEnd, inorder, inorderRootIndex + 1, inEnd, maps);
            return root;
        }

        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (inorder.Length == 0) return null;

            int rootVal = preorder[0];
            preorder = preorder.Skip(1).ToArray(); // preOrder first always be root
            TreeNode node = new TreeNode(rootVal);
            int midIndex = Array.IndexOf(inorder, rootVal); // index < midIndex's  will be left side. >midIndex be right side;
            int[] newLeftPreOrder = preorder.Take(midIndex).ToArray();
            int[] newLeftInOrder = inorder.Take(midIndex).ToArray();
            node.left = BuildTree(newLeftPreOrder, newLeftInOrder);

            int[] newRightPreOrde = preorder.Skip(midIndex).ToArray();
            int[] newRightInOrder = inorder.Skip(midIndex + 1).ToArray();
            node.right = BuildTree(newRightPreOrde, newRightInOrder);

            return node;
        }

        private static void _helper()
        {
            // if () return null;
        }
    }
}