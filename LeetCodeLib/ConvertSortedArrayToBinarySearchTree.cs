using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public static class ConvertSortedArrayToBinarySearchTree
    {
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null) return null;
            return BinarySearchHelper(nums, 0, nums.Length - 1);
        }

        private static TreeNode BinarySearchHelper(int[] nums, int left, int right)
        {
            if (left > right) return null;
            int middle = left + (right - left) / 2;
            TreeNode newNode = new TreeNode(nums[middle]);
            newNode.left = BinarySearchHelper(nums, left, middle - 1);
            newNode.right = BinarySearchHelper(nums, middle + 1, right);
            return newNode;
        }
    }
}