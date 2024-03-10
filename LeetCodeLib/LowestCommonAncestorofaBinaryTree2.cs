using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Runtime.CompilerServices;

namespace LeetCodeLib
{
    /// <summary>
    /// 236. Lowest Common Ancestor of a Binary Tree
    /// Using DFS search Q P node in tree.
    /// Root is ==  p or q, return node
    /// If p != null || q!=null. LCA have to be not null one.
    /// If p && q also find value LCA will be curr.
    /// #Leetcode150
    /// T:O(n)
    /// S:O(h)
    /// </summary>
    public class LowestCommonAncestorofaBinaryTree2
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            if (root.val.Value == p.val.Value || root.val.Value == q.val.Value)
                return root;
            var lNode = this.LowestCommonAncestor(root.left, p, q);
            var rNode = this.LowestCommonAncestor(root.right, p, q);
            if (lNode != null && rNode != null)
                return root;
            return lNode != null ? lNode : rNode;
        }
    }
}