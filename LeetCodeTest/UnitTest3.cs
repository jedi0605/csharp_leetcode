using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeetCodeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest
{
    [TestClass]
    public class UnitTest3
    {
        public static bool CompareArrays(int[][] array1, int[][] array2)
        {
            try
            {
                if (array1.Length != array2.Length)
                    return false;

                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i].Length != array2[i].Length)
                        return false;

                    if (!array1[i].SequenceEqual(array2[i]))
                        return false;
                }
                return true;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static bool AreIListOfIListEqual(IList<IList<int>> list1, IList<IList<int>> list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                IList<int> sublist1 = list1[i];
                IList<int> sublist2 = list2[i];
                if (!sublist1.SequenceEqual(sublist2))
                    return false;
            }
            return true;
        }

        [TestMethod]
        public void InsertIntervalTest()
        {
            int[][] input = { new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 6, 7 }, new int[] { 8, 10 }, new int[] { 12, 16 } };
            int[] newArray = { 4, 8 };
            int[][] ans = InsertInterval.Insert(input, newArray);
            int[][] assert = { new int[] { 1, 2 }, new int[] { 3, 10 }, new int[] { 12, 16 } };
            Assert.IsTrue(CompareArrays(ans, assert));
        }

        [TestMethod]
        public void UpdateMatrixBFSTest()
        {
            int[][] input = { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 1, 1, 1 } };

            int[][] res = ZeroOneMatrix.UpdateMatrixBFS(input);
        }

        [TestMethod]
        public void KClosestTest()
        {
            int[][] input = { new int[] { 1, 3 }, new int[] { -2, 2 } };
            int[][] res = KClosestPointsOrigin.KClosest(input, 1);
            int[][] ans = { new int[] { -2, 2 } };
            Assert.IsTrue(CompareArrays(res, ans));
        }

        [TestMethod]
        public void LongestSubstringWithoutRepeatingCharactersTest()
        {
            string case1 = "abcabcbb";
            int assert = 3;
            Assert.IsTrue(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(case1) == assert);
            Assert.IsTrue(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstringSlidingWindow(case1) == assert);
        }

        [TestMethod]
        public void ThreeSumTest()
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> res = ThreeSum.Sum(nums);
            Assert.IsTrue(res.Count == 2);
        }

        [TestMethod]
        public void BinaryTreeLevelOrderTraversalTest()
        {
            int?[] nums = { 3, 9, 20, null, null, 15, 7 };
            BinaryTree tree = new BinaryTree(nums);

            IList<IList<int>> res = BinaryTreeLevelOrderTraversal.LevelOrder(tree.root);
            IList<IList<int>> answer = new List<IList<int>>(){
                new List<int> {3},
                new List<int> {9,20},
                new List<int> {15,7},
            };
            Assert.IsTrue(AreIListOfIListEqual(res,answer));
        }
    }
}