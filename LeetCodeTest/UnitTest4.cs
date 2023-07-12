using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeetCodeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void SpiralMatrixReviewTest()
        {
            int[][] input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            IList<int> res = SpiralMatrixReview.SpiralOrder(input);
            Assert.IsTrue(res.Count == 9);
        }
        [TestMethod]
        public void SpiralMatrixReviewTest2()
        {
            int[][] input = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 } };
            IList<int> res = SpiralMatrixReview.SpiralOrder(input);
            Assert.IsTrue(res.Count == 12);
        }

        [TestMethod]
        public void SubSetsTest()
        {
            int[] nums = new int[] { 1, 2, 3 };
            IList<IList<int>> res = Subsets.GetSubsets(nums);
            Assert.IsTrue(res.Count == 8);
        }

        [TestMethod]
        public void BinaryTreeRightSideViewTest()
        {
            int?[] nums = new int?[] { 1, 2, 3, null, 5, null, 4 };
            BinaryTree tree = new BinaryTree(nums);
            IList<int> res = BinaryTreeRightSideView.RightSideView(tree.root);
            Assert.IsTrue(res.Count == 3);
        }

        [TestMethod]
        public void LongestPalindromicSubstringTest()
        {
            string s = "aabbaa";
            Assert.IsTrue(LongestPalindromicSubstring.LongestPalindrome(s) == s);
        }

        [TestMethod]
        public void UniquePathsTest()
        {
            Assert.IsTrue(UniquePaths.GetPaths(3, 7) == 28);
            // Assert.IsTrue(LongestPalindromicSubstring.LongestPalindrome(s) == s);
        }

        [TestMethod]
        public void ConstructBinaryTreeFromPreorderAndInorderTraversalTest()
        {
            int[] preOrder = new int[] { 3, 9, 20, 15, 7 };
            int[] inOrder = new int[] { 9, 3, 15, 20, 7 };
            ConstructBinaryTreeFromPreorderAndInorderTraversal.BuildTree(preOrder, inOrder);
            ConstructBinaryTreeFromPreorderAndInorderTraversal.BuildTreeV2(preOrder, inOrder);
            // Assert.IsTrue(LongestPalindromicSubstring.LongestPalindrome(s) == s);
        }


        [TestMethod]
        public void ContainerWithMostWaterTest()
        {
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            ContainerWithMostWater w = new ContainerWithMostWater();
            Assert.IsTrue(w.MaxArea(height) == 49);
        }

    }
}