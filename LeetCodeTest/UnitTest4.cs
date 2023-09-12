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

        [TestMethod]
        public void LetterCombinationsTest()
        {
            string digits = "23";
            LetterCombinations w = new LetterCombinations();
            IList<string> res = w.Combinations(digits);
            Assert.IsTrue(res.Count == 9);
        }

        [TestMethod]
        public void WordSearchTest()
        {
            string word = "ABCCED";
            char[][] board = new char[][] { new char[] { 'A', 'B', 'C', 'E' }, new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } };
            WordSearch solution = new WordSearch();

            Assert.IsTrue(solution.Exist(board, word));
        }

        [TestMethod]
        public void FindAllAnagramsAnAStringTest()
        {
            string word = "abc";
            FindAllAnagramsInAString t = new FindAllAnagramsInAString();
            t.FindAnagrams("cbaebabacd", word);

        }

        [TestMethod]
        public void FindAllAnagramsAnAString2Test()
        {
            string word = "aa";
            FindAllAnagramsInAString t = new FindAllAnagramsInAString();
            t.FindAnagrams("baa", word);
            int n = 1;
            int[,] dp = new int[n, 5];
        }

        [TestMethod]
        public void CountStringPermutationsTest()
        {
            int n = 764;
            int res = CountStringPermutations.countPerms(764);
            Assert.IsTrue(CountStringPermutations.countPerms(764) == 888683244);
        }


        [TestMethod]
        public void KeyboardTest()
        {
            string s = "423692";
            string keypad = "923857614";
            int res = Keyboard.entryTime(s, keypad);
            Assert.IsTrue(res == 8);
        }

        [TestMethod]
        public void BalanceSumTest()
        {
            List<int> arr = new List<int> { 1, 2, 3, 3 };
            string t = BalanceSum.BalancedSumString(arr);

            List<int> arr2 = new List<int> { 1, 2, 1, 1 };
            string t2 = BalanceSum.BalancedSumString(arr2);
        }

        [TestMethod]
        public void InheritanceTest()
        {
            Box0 box0 = null;
            Box1 box1 = new Box2();
            box0 = box1;
            string s = box0.GetText();
        }

        [TestMethod]
        public void MinimumHeightTreesTesst()
        {
            int n = 6;
            int[][] input = new int[][] { new int[] { 3, 0 }, new int[] { 3, 1 }, new int[] { 3, 2 }, new int[] { 3, 4 }, new int[] { 5, 4 } };
            MinimumHeightTrees t = new MinimumHeightTrees();
            IList<int> res = t.FindMinHeightTrees(n, input);
            Assert.IsTrue(res.Count == 2);
        }
    }
}