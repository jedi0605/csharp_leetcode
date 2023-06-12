using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class ValidateBinarySearchTree
    {
        /// <summary>
        /// Using stack to traveling whole tree.
        /// Doing inOrder travel.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsValidBSTStackApproach(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            int? low = null;
            TreeNode cur = root;
            while (cur != null || s.Count > 0)
            {
                while (cur != null)
                {
                    s.Push(cur);
                    cur = cur.left;
                }
                cur = s.Pop();
                if (low != null && low >= cur.val.Value) return false;
                System.Diagnostics.Debug.WriteLine(cur.val.Value);
                low = cur.val.Value;
                cur = cur.right;
            }
            return true;
        }


        // using DFS to travel whole tree.
        // than got a int arr.
        // If is validBTS (index[i] < indexpi+1] == true)
        public static bool IsValidBST(TreeNode root)
        {
            List<int> inorderList = new List<int>();
            inorderList = _inOrder(root, inorderList);
            for (int i = 0; i < inorderList.Count - 1; i++)
            {
                if (inorderList[i] >= inorderList[i + 1])
                    return false;
            }
            return true;
        }

        private static List<int> _inOrder(TreeNode root, List<int> inorderList)
        {
            if (root == null) return null;
            _inOrder(root.left, inorderList);
            inorderList.Add(root.val.Value);
            _inOrder(root.right, inorderList);
            return inorderList;
        }

        private static bool _DfsHelper(TreeNode root, int min, int max)
        {
            if (root == null) return true;
            if (root.val.Value <= min || root.val.Value >= max)
                return false;
            return _DfsHelper(root.left, min, root.val.Value) && _DfsHelper(root.right, root.val.Value, max);
        }
    }
}