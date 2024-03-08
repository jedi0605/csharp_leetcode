using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel;

namespace LeetCodeLib
{
    /// <summary>
    /// LeetCode 129. Sum Root to Leaf Numbers
    /// Using postorder DFS search to calculate each sub tree max value,
    /// and return curr+left or curr+right
    /// </summary>
    /// 

    public class BinaryTreeMaximumPathSum
    {
        private int max = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            _dfs(root);
            return max;
        }
        private int _dfs(TreeNode root)
        {
            if (root == null) return 0;

            int left = Math.Max(0, _dfs(root.left));
            int right = Math.Max(0, _dfs(root.right));
            max = Math.Max(max, root.val.Value + left + right);
            return Math.Max(left + root.val.Value, right + root.val.Value);
        }
    }
}