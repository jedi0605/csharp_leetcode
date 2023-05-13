using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class SameTree
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (p == null || q == null)
                return false;

            if (q.val != p.val)
                return false;

            if (IsSameTree(p.left, q.left) == false)
                return false;
            if (IsSameTree(p.right, q.right) == false)
                return false;
            return true;
        }

    }
}