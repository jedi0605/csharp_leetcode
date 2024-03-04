using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata.Ecma335;

namespace LeetCodeLib
{
    /// <summary>
    /// Construct Binary Tree from Inorder and Postorder Traversal
    /// inorder = [9,3,15,20,7], 
    /// postorder = [9,15,7,20,3]
    /// in postorder will know last element will be root.
    /// than inorder and seperate to Left-Right side
    /// 9 <   > 15,20,7
    /// preorder: root > left > right
    ///
    /// InOrder > always traversal the leftest side.
    /// inorder: left > root > right
    /// </summary>
    /// 

    public static class ConstructBinaryTreefromInorderandPostorderTraversal
    {
        static Dictionary<int, int> inorderIdx = new Dictionary<int, int>();
        public static TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            for (int i = 0; i < inorder.Length; i++)
                inorderIdx.Add(inorder[i], i);

            List<int> inor = new List<int>(inorder);
            List<int> postOr = new List<int>(postorder);

            return _helper(inor, 0, inor.Count - 1, postOr);
        }

        public static TreeNode _helper(List<int> inorder, int L, int R, List<int> postorder)
        {
            if (L > R)
                return null;
            int val = postorder.Last();
            postorder.Remove(val);
            TreeNode root = new TreeNode(val);
            int idx = inorderIdx[val];


            // List<int> inorderR = inorder.GetRange(idx + 1, inorder.Count - idx - 1);
            root.right = _helper(inorder, idx + 1, R, postorder);

            // List<int> inorderL = inorder.GetRange(0, idx);
            root.left = _helper(inorder, L, idx - 1, postorder);

            return root;
        }
    }
}