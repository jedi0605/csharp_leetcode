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
    public static class ConstructBinaryTreeFromPreorderAndInorderTraversal2
    {
        /// <summary>
        /// Better performance. EZ understanding.
        /// 
        /// </summary>
        /// <param name="preorder"></param>
        /// <param name="inorder"></param>
        /// <returns></returns>
        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            List<int> pre = new List<int>(preorder);
            List<int> inOrder = new List<int>(inorder);
            return _helper(pre, inOrder);
        }

        public static TreeNode _helper(List<int> preorder, List<int> inorder)
        {
            if (preorder.Count == 0 && inorder.Count == 0)
                return null;
            TreeNode root = new TreeNode(preorder[0]);
            int mid = inorder.IndexOf(preorder[0]);

            List<int> preLeft = preorder.GetRange(1, mid); // from 1 get mid count
            List<int> inLeft = inorder.GetRange(0, mid); // from 0 until mid
            root.left = _helper(preLeft, inLeft);


            List<int> preR = preorder.GetRange(mid + 1, preorder.Count - mid - 1);
            List<int> inR = inorder.GetRange(mid + 1, inorder.Count - mid - 1);
            root.right = _helper(preR, inR);
            return root;
        }
    }
}