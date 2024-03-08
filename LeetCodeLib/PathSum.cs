using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel;

namespace LeetCodeLib
{
    /// <summary>
    /// LeetCode 112. Path Sum
    /// 1.DFS Stack to track total sum.
    /// </summary>
    /// 

    public static class PathSum
    {
        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;

            targetSum -= root.val.Value;
            if (root.left == null && root.right == null)
            {
                return targetSum == 0;
            }
            bool leftR = PathSum.HasPathSum(root.left, targetSum);
            bool rightR = PathSum.HasPathSum(root.right, targetSum);
            return leftR || rightR;
        }
    }
}