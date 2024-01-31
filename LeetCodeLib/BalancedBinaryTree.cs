namespace LeetCodeLib
{
    public static class BalancedBinaryTree
    {
        public static bool IsBalance(TreeNode root)
        {
            if (root == null)
                return true;
            if (root.left == null && root.right == null) // No sub tree.
                return true;

            int lH = GetTreeHight(root.left);
            int rH = GetTreeHight(root.right);
            bool diffHightOverOne = Math.Abs(lH - rH) <= 1;

            return diffHightOverOne && IsBalance(root.left) && IsBalance(root.right);
        }

        public static int GetTreeHight(TreeNode node)
        {
            if (node == null) return 0;
            System.Diagnostics.Debug.WriteLine(node.val);
            var left = GetTreeHight(node.left) + 1;
            var right = GetTreeHight(node.right) + 1;
            return Math.Max(left, right);
        }
    }
}