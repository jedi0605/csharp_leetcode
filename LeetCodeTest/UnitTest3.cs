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
            Assert.IsTrue(AreIListOfIListEqual(res, answer));
        }

        [TestMethod]
        public void CloneGraphTest()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            node1.neighbors.Add(node2);
            node1.neighbors.Add(node4);

            node2.neighbors.Add(node1);
            node2.neighbors.Add(node3);

            node3.neighbors.Add(node2);
            node3.neighbors.Add(node4);

            node4.neighbors.Add(node1);
            node4.neighbors.Add(node3);

            Node deepRes = CloneGraph.DeepCloneGraph(node1);
        }

        [TestMethod]
        public void EvaluateReversePolishNotationTest()
        {
            string[] toke = { "2", "1", "+", "3", "*" };
            Assert.IsTrue(EvaluateReversePolishNotation.EvalRPN(toke) == 9);
            string[] toke2 = { "4", "13", "5", "/", "+" };
            Assert.IsTrue(EvaluateReversePolishNotation.EvalRPN(toke2) == 6);
        }


        [TestMethod]
        public void CourseScheduleTest()
        {
            int numCourses = 8;
            int[][] prerequisites = { new int[] { 1, 0 }, new int[] { 2, 6 }, new int[] { 1, 7 }, new int[] { 5, 1 }, new int[] { 6, 4 }, new int[] { 7, 0 }, new int[] { 0, 5 } };
            CourseSchedule cs = new CourseSchedule();
            bool res = cs.CanFinish(numCourses, prerequisites);
        }


        [TestMethod]
        public void CourseScheduleTest2()
        {
            int numCourses = 5;
            int[][] prerequisites = { new int[] { 2, 0 }, new int[] { 2, 1 }, new int[] { 4, 2 }, new int[] { 4, 3 } };
            CourseSchedule cs = new CourseSchedule();
            bool res = cs.CanFinish(numCourses, prerequisites);
        }

        [TestMethod]
        public void ImplementTrieTest()
        {
            string word = "apple";
            string preWord = "app";
            TrieHashVer t = new TrieHashVer();
            t.Insert(word);
            Assert.IsTrue(t.Search(word));
            Assert.IsTrue(t.Search(preWord) == false);
            Assert.IsTrue(t.StartsWith(preWord) == true);
        }

        [TestMethod]
        public void ImplementTrieTest2()
        {
            string word = "apple";
            string preWord = "app";
            Trie t = new Trie();
            t.Insert(word);
            Assert.IsTrue(t.Search(word));
            Assert.IsTrue(t.Search(preWord) == false);
            Assert.IsTrue(t.StartsWith(preWord) == true);
        }


        [TestMethod]
        public void CoinChangeTest()
        {
            int[] coins = { 1, 2, 5 };
            int amount = 11;
            Assert.IsTrue(CoinChange.Change(coins, amount) == 3);

            int[] coins2 = { 2 };
            int amount2 = 3;
            Assert.IsTrue(CoinChange.Change(coins2, amount2) == -1);

            int[] coins3 = { 2, 5, 10, 1 };
            int amount3 = 27;
            Assert.IsTrue(CoinChange.Change(coins3, amount3) == 4);
        }

        [TestMethod]
        public void CoinChangeTest2()
        {
            int[] coins = { 186, 419, 83, 408 };
            int amount = 6249;
            Assert.IsTrue(CoinChange.Change(coins, amount) == 20);
        }

        [TestMethod]
        public void ProductExceptSelfTest()
        {
            ProductOfArrayExceptSelf solution = new ProductOfArrayExceptSelf();
            int[] nums = { 1, 2, 3, 4 };
            int[] ans = { 24, 12, 8, 6 };
            int[] res = solution.ProductExceptSelf(nums);
            Assert.IsTrue(res.SequenceEqual(ans));
        }

        [TestMethod]
        public void ValidateBinarySearchTreeTest()
        {
            int?[] treeNode = { 50, 30, 70, 20, 45, 60, 100 };
            BinaryTree t = new BinaryTree(treeNode);
            bool res = ValidateBinarySearchTree.IsValidBST(t.root);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ValidateBinarySearchTreeStaskTest()
        {
            int?[] treeNode = { 50, 30, 70, 20, 45, 60, 100 };
            BinaryTree t = new BinaryTree(treeNode);
            bool res = ValidateBinarySearchTree.IsValidBSTStackApproach(t.root);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void NumberOfIslandsDFSTest()
        {
            char[][] input = {
                new char[] { '1','1','1','1','0'},
                new char[] { '1','1','0','1','0' },
                new char[] { '1','1','0','0','0' },
                new char[] { '0','0','0','0','0' }};
            int res = NumberOfIslands.NumIslands(input);
            Assert.IsTrue(res == 1);
        }

        [TestMethod]
        public void RottingOrangesTest()
        {
            int[][] grid = {
                new int[] { 2,1,1},
                new int[] { 1,1,0 },
                new int[] { 0,1,1 }};

            int res = RottingOranges.OrangesRotting(grid);
            Assert.IsTrue(res == 4);
        }

        [TestMethod]
        public void SearchInRotatedSortedArrayTest()
        {
            int[] nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            Assert.IsTrue(SearchInRotatedSortedArray2.GetMinIndex(nums) == 4);


            int[] nums2 = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            Assert.IsTrue(SearchInRotatedSortedArray2.GetMinIndex(nums2) == 0);

        }

        [TestMethod]
        public void SearchInRotatedSortedArray2Test()
        {
            int[] nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            Assert.IsTrue(SearchInRotatedSortedArray2.Search(nums, 0) == 4);

            Assert.IsTrue(SearchInRotatedSortedArray2.Search(nums, 3) == -1);

            Assert.IsTrue(SearchInRotatedSortedArray2.Search(nums, 1) == 5);
        }

        [TestMethod]
        public void SearchInRotatedSortedArray3Test()
        {
            int[] nums = new int[] { 1, 3 };
            Assert.IsTrue(SearchInRotatedSortedArray2.Search(nums, 3) == 1);
        }

        [TestMethod]
        public void CombinationSumTest()
        {
            int[] nums = new int[] { 2, 3, 6, 7 };
            CombinationSum.Sum(nums, 7);
        }

        [TestMethod]
        public void PermutationTest()
        {
            int[] nums = new int[] { 1, 2, 3 };
            IList<IList<int>> res = Permutations.Permute(nums);
            Assert.IsTrue(res.Count == 6);
        }

        [TestMethod]
        public void MergeIntervalsTest()
        {
            int[][] nums =
             {
                new int[]{1,4},
                new int[]{4,5}
                 };
            int[][] res = MergeIntervals.Merge(nums);
        }

        [TestMethod]
        public void MergeIntervalsTest2()
        {
            int[][] nums =
             {
                new int[]{1,3},
                new int[]{2,6},
                new int[]{8,10},
                new int[]{15,18},
                 };
            int[][] res = MergeIntervals.Merge(nums);
        }

        [TestMethod]
        public void LowestCommonAncestorOfABinaryTreeTest()
        {
            int?[] node = { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 };
            BinaryTree t = new BinaryTree(node);
            TreeNode p = new TreeNode(5);
            TreeNode q = new TreeNode(1);
            TreeNode ans = LowestCommonAncestorOfABinaryTree.LowestCommonAncestor(t.root, p, q);
            Assert.IsTrue(ans.val == 3);
        }

        [TestMethod]
        public void TimeBasedKeyValueStoreTest()
        {
            TimeMap map = new TimeMap();
            map.Set("foo", "bar", 1);
            map.Set("foo", "bar2", 4);
            map.Get("foo", 5);
        }
    }
}