using System.Data;
using System.Runtime;
using LeetCodeLib;
namespace LeetCodeTest;

[TestClass]
public class LeetCode150_1
{
    [TestMethod]
    public void MergeSortedArrayTest()
    {
        int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        int m = 3;

        int[] nums2 = new int[] { 2, 5, 6 };
        int n = 3;


        MergeSortedArray mergeSorted = new MergeSortedArray();
        // mergeSorted.MergeBF(nums1,m,nums2,n);

        mergeSorted.Merge(nums1, m, nums2, n);
    }

    [TestMethod]
    public void RemoveElementTest()
    {
        int[] nums1 = new int[] { 3, 2, 2, 3 };
        int val = 3;
        RemoveElement sol = new RemoveElement();
        int k = sol.RemoveElementBF(nums1, val);
        Assert.IsTrue(k == 2);

        int[] ans = new int[] { 2, 2 };
        for (int i = 0; i < ans.Length; i++)
        {
            Assert.AreEqual(ans[i], nums1[i]);
        }
    }

    [TestMethod]
    public void RemoveDuplicatesfromSortedArrayTest()
    {
        int[] nums1 = new int[] { 1, 1, 2 };
        int[] ans1 = new int[] { 1, 2 };
        int k = 2;

        RemoveDuplicates sol = new RemoveDuplicates();

        Assert.IsTrue(sol.Sol(nums1) == k);
        for (int i = 0; i < ans1.Length; i++)
        {
            Assert.IsTrue(ans1[i] == nums1[i]);
        }
    }

    [TestMethod]
    public void RemoveDuplicatesfromSortedArrayIITest()
    {
        int[] nums1 = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
        int[] ans1 = new int[] { 0, 0, 1, 1, 2, 3, 3 };
        int k = 7;

        RemoveDuplicatesFromSortedArrayII sol = new RemoveDuplicatesFromSortedArrayII();

        Assert.IsTrue(sol.RemoveDuplicates(nums1) == k);
        for (int i = 0; i < ans1.Length; i++)
        {
            Assert.IsTrue(ans1[i] == nums1[i]);
        }
    }

    [TestMethod]
    public void MajorityElement2Test()
    {
        int[] nums = { 2, 2, 2, 1, 1, 1, 2, 2 };
        MajorityElement2 c = new MajorityElement2();

        Assert.IsTrue(c.MajorityElement(nums) == 2);
    }

    [TestMethod]
    public void ReverseTest()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6 };
        int k = 3;
        RotateArray sol = new RotateArray();
        sol._reverse(nums, 0, nums.Length - 1);
    }

    [TestMethod]
    public void RotateArrayTest()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;
        RotateArray sol = new RotateArray();
        sol.Rotate2(nums, k);
        int[] res = { 5, 6, 7, 1, 2, 3, 4 };
        for (int i = 0; i < res.Length; i++)
        {
            Assert.IsTrue(nums[i] == res[i]);
        }
    }

    [TestMethod]
    public void RotateArrayTest2()
    {
        int[] nums = { -1, -100, 3, 99 };
        int k = 2;
        RotateArray sol = new RotateArray();
        sol.Rotate2(nums, k);
        int[] res = { 3, 99, -1, -100 };
        for (int i = 0; i < res.Length; i++)
        {
            Assert.IsTrue(nums[i] == res[i]);
        }
    }

    [TestMethod]
    public void BestTimeBuySellStockTest()
    {
        int[] nums = { 7, 1, 5, 3, 6, 4 };
        int ans = 5;
        BestTimeBuySellStock sol = new BestTimeBuySellStock();
        Assert.IsTrue(sol.MaxProfit(nums) == ans);
    }

    [TestMethod]
    public void BestTimeBuySellStockTest2()
    {
        int[] nums = { 7, 6, 4, 3, 1 };
        int ans = 0;
        BestTimeBuySellStock sol = new BestTimeBuySellStock();
        Assert.IsTrue(sol.MaxProfit(nums) == ans);
    }

    [TestMethod]
    public void BestTimeBuySellStock2Test()
    {
        int[] nums = { 7, 1, 5, 3, 6, 4 };
        int ans = 7;
        int res = BestTimeBuySellStock2.MaxProfit(nums);
        Assert.IsTrue(res == ans);
    }

    [TestMethod]
    public void BestTimeBuySellStock2Test2()
    {
        int[] nums = { 7, 6, 4, 3, 1 };
        int ans = 0;
        int res = BestTimeBuySellStock2.MaxProfit(nums);
        Assert.IsTrue(res == ans);
    }

    [TestMethod]
    public void JumpGameTest1()
    {
        int[] nums = { 2, 3, 1, 1, 4 };
        bool res = JumpGame.CanJump2(nums);
        Assert.IsTrue(res == true);

        int[] nums2 = { 3, 2, 1, 0, 4 };
        res = JumpGame.CanJump2(nums2);
        Assert.IsTrue(res == false);

        int[] nums3 = { 0, 1 };
        res = JumpGame.CanJump2(nums3);
        Assert.IsTrue(res == false);
    }

    [TestMethod]
    public void JumpGameIITest1()
    {
        int[] nums = { 2, 3, 1, 1, 4 };
        int res = JumpGameII.Jump(nums);
        Assert.IsTrue(res == 2);

        int[] nums2 = { 2, 3, 0, 1, 4 };
        res = JumpGameII.Jump(nums2);
        Assert.IsTrue(res == 2);
    }

    [TestMethod]
    public void HindexTest()
    {
        int[] nums = { 3, 0, 6, 1, 5 };
        int res = Hindex.GetIndex2(nums);
        Assert.IsTrue(res == 3);
    }

    [TestMethod]
    public void ProductOfArrayExceptSelf_2Test()
    {
        int[] nums = { 1, 2, 3, 4 };
        int[] res = ProductOfArrayExceptSelf_2.ProductExceptSelf(nums);
        int[] ans = { 24, 12, 8, 6 };
        Assert.IsTrue(res.SequenceEqual(ans));
    }

    [TestMethod]
    public void GasStationTest()
    {
        int[] gas = { 1, 2, 3, 4, 5 };
        int[] cost = { 3, 4, 5, 1, 2, };
        GasStation gasStation = new GasStation();
        int index = gasStation.CanCompleteCircuit2(gas, cost);
        Assert.IsTrue(index == 3);
    }

    [TestMethod]
    public void GasStationTest2()
    {
        int[] gas = { 2, 3, 4 };
        int[] cost = { 3, 4, 3 };
        GasStation gasStation = new GasStation();
        int index = gasStation.CanCompleteCircuit2(gas, cost);
        Assert.IsTrue(index == -1);
    }

    [TestMethod]
    public void GetCandyTest()
    {
        int[] rating = { 1, 0, 2 };
        Candy candy = new Candy();
        int res = candy.GetCandy(rating);
        Assert.IsTrue(res == 5);
    }

    [TestMethod]
    public void TrappingRainWaterTest()
    {
        int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        TrappingRainWater trapping = new TrappingRainWater();
        Assert.IsTrue(trapping.Trap2(height) == 6);

        height = new int[] { 4, 2, 0, 3, 2, 5 };
        Assert.IsTrue(trapping.Trap2(height) == 9);
    }

    [TestMethod]
    public void IntToRomanTest()
    {
        Assert.IsTrue(IntergerToRoman.IntToRoman(3) == "III");
        Assert.IsTrue(IntergerToRoman.IntToRoman(58) == "LVIII");
        Assert.IsTrue(IntergerToRoman.IntToRoman(1994) == "MCMXCIV");
    }

    [TestMethod]
    public void LengthOfLastWordTest()
    {
        Assert.IsTrue(LengthOfLastWord.LengthLastWord("Hello World") == 5);
        Assert.IsTrue(LengthOfLastWord.LengthLastWord("   fly me   to   the moon  ") == 4);
        Assert.IsTrue(LengthOfLastWord.LengthLastWord("luffy is still joyboy") == 6);
    }

    [TestMethod]
    public void ReversewordsTest()
    {
        Assert.IsTrue(ReverseWordsInAString.ReverseWords2("the sky is blue") == "blue is sky the");
        Assert.IsTrue(ReverseWordsInAString.ReverseWords2("  hello world  ") == "world hello");
        Assert.IsTrue(ReverseWordsInAString.ReverseWords2("a good   example") == "example good a");
    }

    [TestMethod]
    public void ZigzagConversionTest()
    {
        Assert.IsTrue(ZigzagConversion.Convert3("PAYPALISHIRING", 3) == "PAHNAPLSIIGYIR");
        Assert.IsTrue(ZigzagConversion.Convert3("PAYPALISHIRING", 4) == "PINALSIGYAHRPI");
    }

    [TestMethod]
    public void FindIndexOfTFirstOccurrenceInStringTest()
    {
        Assert.IsTrue(FindIndexOfTFirstOccurrenceInString.StrStr("sadbutsad", "sad") == 0);
        Assert.IsTrue(FindIndexOfTFirstOccurrenceInString.StrStr("leetcode", "leeto") == -1);
        Assert.IsTrue(FindIndexOfTFirstOccurrenceInString.StrStr("a", "a") == 0);
        Assert.IsTrue(FindIndexOfTFirstOccurrenceInString.StrStr("abc", "c") == 2);
    }

    [TestMethod]
    public void TextJustificationTets()
    {
        string[] input = new string[] { "This", "is", "an", "example", "of", "text", "justification." };

        IList<string> res = TextJustification.FullJustify(input, 16);
        string[] ans = new string[] { "This    is    an", "example  of text", "justification.  " };
        for (int i = 0; i < res.Count; i++)
        {
            Assert.IsTrue(res[i] == ans[i]);
        }
    }

    [TestMethod]
    public void IsSubsequenceTest()
    {
        string s = "abc";
        string t = "ahbgdc";
        Assert.IsTrue(IsSubsequence.IsSub(s, t));

        string s1 = "axc";
        string t1 = "ahbgdc";
        Assert.IsTrue(IsSubsequence.IsSub(s1, t1) == false);
    }

    [TestMethod]
    public void TwoSumIITest()
    {
        int target = 9;
        int[] nums = new int[] { 2, 7, 11, 15 };
        var res = TwoSumII.TwoSum(nums, target);
        int[] ans = new int[] { 1, 2 };
        Assert.IsTrue(res.SequenceEqual(ans));
    }

    [TestMethod]
    public void ThreeSum2IITest()
    {
        int[] nums = { -1, 0, 1, 2, -1, -4 };
        IList<IList<int>> res = ThreeSum2.Sum(nums);
        IList<IList<int>> ans = new List<IList<int>>();
        ans.Add(new List<int>() { -1, -1, 2 });
        ans.Add(new List<int>() { -1, 0, 1 });
        Assert.IsTrue(res.Count == 2);

    }

    [TestMethod]
    public void MinimumSizeSubarraySumTest()
    {
        int[] nums = new int[] { 2, 3, 1, 2, 4, 3 };
        int target = 7;
        Assert.IsTrue(MinimumSizeSubarraySum.MinSubArrayLen(target, nums) == 2);
    }

    [TestMethod]
    public void LongestSubstringWithoutRepeatingCharactersTest()
    {
        string case1 = "abcabcbb";
        Assert.IsTrue(LongestSubstringWithoutRepeatingCharacters2.LengthOfLongestSubstringSlidingWindow2(case1) == 3);
        case1 = " ";
        Assert.IsTrue(LongestSubstringWithoutRepeatingCharacters2.LengthOfLongestSubstringSlidingWindow2(case1) == 1);

        case1 = "bbbbb";
        Assert.IsTrue(LongestSubstringWithoutRepeatingCharacters2.LengthOfLongestSubstringSlidingWindow2(case1) == 1);
        case1 = "aab";
        Assert.IsTrue(LongestSubstringWithoutRepeatingCharacters2.LengthOfLongestSubstringSlidingWindow2(case1) == 2);
    }

    [TestMethod]
    public void SubstringWithConcatenationOfAllWordsTest()
    {
        string s = "barfoothefoobarman";
        string[] words = new string[] { "foo", "bar" };
        var res = SubstringWithConcatenationOfAllWords.FindSubstring(s, words);
        List<int> ans = new List<int>() { 0, 9 };
        for (int i = 0; i < res.Count; i++)
        {
            Assert.IsTrue(res[i] == ans[i]);
        }
    }

    [TestMethod]
    public void MinimumWindowSubstringTest()
    {
        string s = "ADOBECODEBANC";
        string t = "ABC";
        var res = MinimumWindowSubstring.MinWindow(s, t);
        Assert.IsTrue(res == "BANC");
    }

    [TestMethod]
    public void ValidSudokuTest()
    {
        char[][] board = new char[][] {
                new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                new char[] {'4', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
               new char[]  {'7', '.', '.', '.', '2', '.', '.','.', '6'},
                new char[] {'.', '6','.', '.', '.', '.', '2', '8', '.'},
                new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
                };
        bool res = ValidSudoku2.IsValidSudoku(board);
        Assert.IsFalse(res);
    }

    [TestMethod]
    public void SpiralMatrix2Test()
    {
        int[][] input = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 } };
        IList<int> res = SpiralMatrix2.SpiralOrder(input);
        List<int> ans = new List<int>() { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };
        Assert.IsTrue(res.SequenceEqual(ans));
    }
    [TestMethod]
    public void SpiralMatrix2ITest()
    {
        int[][] input = new int[][] { new int[] { 1 }, new int[] { 2 }, new int[] { 3 }, new int[] { 4 } };
        IList<int> res = SpiralMatrix2.SpiralOrder(input);
        List<int> ans = new List<int>() { 1, 2, 3, 4 };
        Assert.IsTrue(res.SequenceEqual(ans));
    }

    [TestMethod]
    public void RotateImageITest()
    {
        int[][] input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
        int[][] ans = new int[][] { new int[] { 7, 4, 1 }, new int[] { 8, 5, 2 }, new int[] { 9, 6, 3 } };
        RotateImage.Rotate(input);
        Assert.IsTrue(AreJaggedArraysEqual(input, ans));
    }

    [TestMethod]
    public void SetMatrixZerosTest()
    {
        int[][] input = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 1, 1 } };

        int[][] ans = new int[][] { new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 }, new int[] { 1, 0, 1 } };
        // SetMatrixZeros.SetZeroes(input);
        SetMatrixZeros.SetMatrixZeros2(input);
        Assert.IsTrue(AreJaggedArraysEqual(input, ans));
    }

    [TestMethod]
    public void SetMatrixZerosTest2()
    {
        int[][] input = new int[][] { new int[] { 0, 1, 2, 0 }, new int[] { 3, 4, 5, 2 }, new int[] { 1, 3, 1, 5 } };

        int[][] ans = new int[][] { new int[] { 0, 0, 0, 0 }, new int[] { 0, 4, 5, 0 }, new int[] { 0, 3, 1, 0 } };
        // SetMatrixZeros.SetZeroes(input);
        SetMatrixZeros.SetMatrixZeros2(input);
        Assert.IsTrue(AreJaggedArraysEqual(input, ans));
    }

    [TestMethod]
    public void GameOfLifeTest()
    {
        int[][] input = new int[][] { new int[] { 0, 1, 0 }, new int[] { 0, 0, 1 }, new int[] { 1, 1, 1 }, new int[] { 0, 0, 0 } };

        int[][] ans = new int[][] { new int[] { 0, 0, 0 }, new int[] { 1, 0, 1 }, new int[] { 0, 1, 1 }, new int[] { 0, 1, 0 } };
        // SetMatrixZeros.SetZeroes(input);
        GameOfLife.GameLife2(input);
        Assert.IsTrue(AreJaggedArraysEqual(input, ans));
    }

    [TestMethod]
    public void IsIsomorphicTest()
    {
        string s = "egg"; string t = "add";
        Assert.IsTrue(IsIsomorphic.Is_Isomorphic(s, t) == true);
    }

    [TestMethod]
    public void IsIsomorphicTest2()
    {
        string s = "foo"; string t = "bar";
        Assert.IsTrue(IsIsomorphic.Is_Isomorphic(s, t) == false);
    }

    [TestMethod]
    public void WordPatternTest()
    {
        string s = "abba"; string t = "dog cat cat dog";
        Assert.IsTrue(WordPattern.IsWordPattern(s, t) == true);
    }

    [TestMethod]
    public void WordPatternTest2()
    {
        string s = "abba"; string t = "dog cat cat fish";
        Assert.IsTrue(WordPattern.IsWordPattern(s, t) == false);
    }

    [TestMethod]
    public void WordPatternTest3()
    {
        string s = "abba"; string t = "dog dog dog dog";
        Assert.IsTrue(WordPattern.IsWordPattern(s, t) == false);
    }


    [TestMethod]
    public void GroupAnagramsTest()
    {
        string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        var res = GroupAnagrams.Group_Anagrams(strs);
        IList<IList<string>> ans = new List<IList<string>>(){ new List<string>(){"eat","tea","ate"},
            new List<string>(){"tan","nat"}, new List<string>(){"bat"}};
        Assert.IsTrue(AreListsEqual(res, ans));
    }

    [TestMethod]
    public void HappyNumberTest()
    {
        int n = 19;
        HappyNumber happyNumber = new HappyNumber();
        Assert.IsTrue(happyNumber.IsHappy(n));
    }

    [TestMethod]
    public void ContainsDuplicateIITest()
    {
        int[] nums = new int[] { 1, 2, 3, 1 };
        int k = 3;
        ContainsDuplicateII duplicateII = new ContainsDuplicateII();
        Assert.IsTrue(duplicateII.ContainsNearbyDuplicate(nums, k));

        nums = new int[] { 1, 0, 1, 1 };
        k = 1;
        Assert.IsTrue(duplicateII.ContainsNearbyDuplicate(nums, k));

        nums = new int[] { 1, 2, 3, 1, 2, 3 };
        k = 2;
        Assert.IsTrue(duplicateII.ContainsNearbyDuplicate(nums, k) == false);
    }

    [TestMethod]
    public void LongestConsecutiveSequenceTest()
    {
        int[] nums = new int[] { 100, 4, 200, 1, 3, 2 };
        Assert.IsTrue(LongestConsecutiveSequence.LongestConsecutive(nums) == 4);
    }


    [TestMethod]
    public void SummaryRangesTest()
    {
        int[] nums = new int[] { 0, 1, 2, 4, 5, 7 };
        var list = SummaryRanges.Summary_Ranges(nums);
        List<string> ans = new List<string>() { "0->2", "4->5", "7" };
        Assert.IsTrue(ans.SequenceEqual(list));
    }

    [TestMethod]
    public void MergeIntervals2Test()
    {
        int[][] nums =
          {
                new int[]{1,4},
                new int[]{4,5}
                 };
        int[][] res = MergeIntervals2.Merge(nums);
        int[][] ans = new int[][] { new int[] { 1, 5 } };
        Assert.IsTrue(res.SequenceEqual(ans));
    }

    [TestMethod]
    public void InsertInterval2Test()
    {
        int[][] input = { new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 6, 7 }, new int[] { 8, 10 }, new int[] { 12, 16 } };
        int[] newArray = { 4, 8 };
        int[][] ans = InsertInterval2.Insert(input, newArray);
        int[][] assert = { new int[] { 1, 2 }, new int[] { 3, 10 }, new int[] { 12, 16 } };
        Assert.IsTrue(AreJaggedArraysEqual(ans, assert));
    }

    [TestMethod]
    public void MinimumNumberOfArrowsToBurstBalloonsTest()
    {

        int[][] input = { new int[] { 10, 16 }, new int[] { 2, 8 }, new int[] { 1, 6 }, new int[] { 7, 12 } };
        int ans = MinimumNumberOfArrowsToBurstBalloons.FindMinArrowShots(input);
        Assert.IsTrue(ans == 2);
    }

    [TestMethod]
    public void ValidParenthesesTest()
    {
        Assert.IsTrue(ValidParentheses2.IsValid("()[]{}"));
        Assert.IsFalse(ValidParentheses2.IsValid("()[]{]"));
    }

    [TestMethod]
    public void SimplifyPathTest()
    {
        string path = "/home/";
        string res = SimplifyPath.Simplify_Path(path);
        Assert.IsTrue(res == "/home");

        path = "/../";
        res = SimplifyPath.Simplify_Path(path);
        Assert.IsTrue(res == "/");

        path = "/home//foo/";
        res = SimplifyPath.Simplify_Path(path);
        Assert.IsTrue(res == "/home/foo");
    }

    [TestMethod]
    public void EvaluateReversePolishNotation2Test()
    {
        string[] toke = { "2", "1", "+", "3", "*" };
        Assert.IsTrue(EvaluateReversePolishNotation2.EvalRPN(toke) == 9);
        string[] toke2 = { "4", "13", "5", "/", "+" };
        Assert.IsTrue(EvaluateReversePolishNotation2.EvalRPN(toke2) == 6);
    }

    [TestMethod]
    public void BasicCalculatorTest()
    {
        string s = "2147483647";
        Assert.IsTrue(BasicCalculator.Calculate(s) == 2147483647);
    }

    [TestMethod]
    public void AddTwoNumbersTest()
    {
        int[] l1 = { 2, 4, 3 };
        int[] l2 = { 5, 6, 4 };
        ListNode list1 = ListNode.ArrayToListNode(l1);
        ListNode list2 = ListNode.ArrayToListNode(l2);
        var res = AddTwoNumber.AddTwoNumbers(list1, list2);
        int[] a = { 7, 0, 8 };
        ListNode ans = ListNode.ArrayToListNode(a);
        Assert.IsTrue(ans.Equals(res));
    }

    [TestMethod]
    public void MergeTwoSortedListsTest()
    {
        int[] l1 = { 1, 2, 4 };
        int[] l2 = { 1, 3, 4 };
        ListNode list1 = ListNode.ArrayToListNode(l1);
        ListNode list2 = ListNode.ArrayToListNode(l2);
        var res = MergeTwoSortedLists2.MergeTwoLists(list1, list2);
        int[] a = { 1, 1, 2, 3, 4, 4 };
        ListNode ans = ListNode.ArrayToListNode(a);
        Assert.IsTrue(ans.Equals(res));
    }

    [TestMethod]
    public void ReverseLinkedListIITest()
    {
        int[] l1 = { 1, 2, 3, 4, 5 };

        ListNode list1 = ListNode.ArrayToListNode(l1);

        var res = ReverseLinkedListII.ReverseBetween(list1, 2, 4);
        int[] a = { 1, 4, 3, 2, 5 };
        ListNode ans = ListNode.ArrayToListNode(a);
        Assert.IsTrue(ans.Equals(res));
    }

    [TestMethod]
    public void ReverseNodesinkGroupTest()
    {
        int[] l1 = { 1, 2, 3, 4, 5 };

        ListNode list1 = ListNode.ArrayToListNode(l1);
        var res = ReverseNodesInKGroup.ReverseKGroup(list1, 2);
        int[] a = { 2, 1, 4, 3, 5 };
        ListNode ans = ListNode.ArrayToListNode(a);
        Assert.IsTrue(ans.Equals(res));
    }

    [TestMethod]
    public void RemoveNthNodeFromEndofListTest()
    {
        int[] l1 = { 1, 2, 3, 4, 5 };
        ListNode list1 = ListNode.ArrayToListNode(l1);
        int k = 2;
        var res = RemoveNthNodeFromEndofList.RemoveNthFromEnd(list1, k);
        int[] a = { 1, 2, 3, 5 };
        ListNode ans = ListNode.ArrayToListNode(a);
        Assert.IsTrue(ans.Equals(res));
    }

    [TestMethod]
    public void RotateListTest()
    {
        int[] l1 = { 1, 2, 3, 4, 5 };
        ListNode list1 = ListNode.ArrayToListNode(l1);
        int k = 2;
        var res = RotateList.RotateRight(list1, k);
        int[] a = { 4, 5, 1, 2, 3 };
        ListNode ans = ListNode.ArrayToListNode(a);
        Assert.IsTrue(ans.Equals(res));
    }

    [TestMethod]
    public void PartitionbListTest()
    {
        int[] l1 = { 1, 4, 3, 2, 5, 2 };
        ListNode list1 = ListNode.ArrayToListNode(l1);
        int k = 3;
        var res = PartitionList.Partition(list1, k);
        int[] a = { 1, 2, 2, 4, 3, 5 };
        ListNode ans = ListNode.ArrayToListNode(a);
        Assert.IsTrue(ans.Equals(res));
    }

    [TestMethod]
    public void LRUCacheTesst()
    {
        LRUCache2 cache = new LRUCache2(2);
        cache.Put(1, 1);
        cache.PrintList();
        cache.Put(2, 2);
        cache.PrintList();
        Assert.IsTrue(cache.Get(1) == 1);
        cache.Put(3, 3);
        cache.PrintList();

        Assert.IsTrue(cache.Get(2) == -1);
        cache.Put(4, 4);
        Assert.IsTrue(cache.Get(1) == -1);
        Assert.IsTrue(cache.Get(3) == 3);
        Assert.IsTrue(cache.Get(4) == 4);
    }

    [TestMethod]
    public void InvertTreeTesst()
    {
        int?[] rootArr = { 4, 2, 7, 1, 3, 6, 9 };
        TreeNode root = TreeNode.ArrToTree(rootArr);
        TreeNode res = InvertBinaryTree2.InvertTree(root);
        Assert.IsTrue(TreeNode.CompareTrees(root, res));
    }

    [TestMethod]
    public void IsSymmetricTest()
    {
        int?[] array = { 1, 2, 2, 3, 4, 4, 3 };
        BinaryTree t = new BinaryTree(array);
        Assert.IsTrue(SymmetricTree2.IsSymmetric(t.root));
    }

    [TestMethod]
    public void ConstructBinaryTreeFromPreorderAndInorderTraversal2Test()
    {

        int[] preOrder = new int[] { 3, 9, 20, 15, 7 };
        int[] inOrder = new int[] { 9, 3, 15, 20, 7 };
        var root = ConstructBinaryTreeFromPreorderAndInorderTraversal2.BuildTree(preOrder, inOrder);
    }


    [TestMethod]
    public void ConstructBinaryTreefromInorderandPostorderTraversalTest()
    {
        int[] inOrder = new int[] { 9, 3, 15, 20, 7 };
        int[] preOrder = new int[] { 9, 15, 7, 20, 3 };
        var root = ConstructBinaryTreefromInorderandPostorderTraversal.BuildTree(inOrder, preOrder);

        int?[] rootArr = { 3, 9, 20, null, null, 15, 7 };
        TreeNode ans = TreeNode.ArrToTree(rootArr);
        Assert.IsTrue(TreeNode.CompareTrees(root, ans));
    }

    [TestMethod]
    public void PopulatingNextRightPointersinEachNodeIITest()
    {
        int?[] inOrder = new int?[] { 1, 2, 3, 4, 5, null, 7 };
        var root = NodeNext.ArrToTree(inOrder);
        var res = PopulatingNextRightPointersinEachNodeII.Connect(root);
    }

    [TestMethod]
    public void FlattenBinaryTreetoLinkedListTest()
    {
        int?[] inOrder = new int?[] { 1, 2, 5, 3, 4, null, 6 };
        var root = TreeNode.ArrToTree(inOrder);
        FlattenBinaryTreetoLinkedList.Flatten(root);
    }

    [TestMethod]
    public void PathSumTest()
    {
        int?[] arr = new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 };
        var root = TreeNode.ArrToTree(arr);
        var test = new BinaryTree(arr);
        int target = 22;
        Assert.IsTrue(PathSum.HasPathSum(root, 22));
    }

    [TestMethod]
    public void SumRootToLeafNumbersTest()
    {
        int?[] arr = new int?[] { 1, 2, 3 };
        var root = TreeNode.ArrToTree(arr);
        Assert.IsTrue(SumRoottoLeafNumbers.SumNumbers(root) == 25);
    }

    [TestMethod]
    public void BinaryTreeMaximumPathSumTest()
    {
        int?[] arr = new int?[] { 1, 2, 3 };
        var root = TreeNode.ArrToTree(arr);
        BinaryTreeMaximumPathSum sol = new BinaryTreeMaximumPathSum();
        Assert.IsTrue(sol.MaxPathSum(root) == 6);
    }

    [TestMethod]
    public void CountCompleteTreeNodesTest()
    {
        int?[] arr = new int?[] { 1, 2, 3, 4, 5, 6 };
        var root = TreeNode.ArrToTree(arr);
        CountCompleteTreeNodes count = new CountCompleteTreeNodes();
        int res = count.CountNodes(root);
        Assert.IsTrue(res == 6);
    }

    [TestMethod]
    public void LowestCommonAncestorofaBinaryTree2()
    {
        int?[] arr = new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 };
        var root = TreeNode.ArrToTree(arr);
        LowestCommonAncestorofaBinaryTree2 sol = new LowestCommonAncestorofaBinaryTree2();
        var res = sol.LowestCommonAncestor(root, new TreeNode(5), new TreeNode(1));

        Assert.IsTrue(res.val.Value == 3);
    }

    [TestMethod]
    public void AverageofLevelsinBinaryTreeTest()
    {
        int?[] arr = new int?[] { 3, 9, 20, null, null, 15, 7 };
        var root = TreeNode.ArrToTree(arr);
        var res = AverageofLevelsinBinaryTree.AverageOfLevels(root);
        List<double> ans = new List<double>() { 3, 14.5, 11 };
        Assert.IsTrue(ans.SequenceEqual(res));
    }

    [TestMethod]
    public void BinaryTreeZigzagLevelOrderTraversalTreeTest()
    {
        int?[] arr = new int?[] { 3, 9, 20, null, null, 15, 7 };
        var root = TreeNode.ArrToTree(arr);
        BinaryTreeZigzagLevelOrderTraversal sol = new BinaryTreeZigzagLevelOrderTraversal();
        var res = sol.ZigzagLevelOrder(root);
        List<IList<int>> ans = new List<IList<int>>();
        ans.Add(new List<int> { 3 });
        ans.Add(new List<int> { 20, 9 });
        ans.Add(new List<int> { 15, 7 });
        Assert.IsTrue(AreListsEqual(res, ans));
    }

    [TestMethod]
    public void MinimumAbsoluteDifferenceinBSTTest()
    {
        int?[] arr = new int?[] { 4, 2, 6, 1, 3 };
        var root = TreeNode.ArrToTree(arr);
        MinimumAbsoluteDifferenceinBST minimum = new MinimumAbsoluteDifferenceinBST();
        var res = minimum.GetMinimumDifference(root);
        Assert.IsTrue(res == 1);
    }

    [TestMethod]
    public void KthSmallestElementinaBSTTest()
    {
        int?[] arr = new int?[] { 5, 3, 6, 2, 4, null, null, 1 };
        var root = TreeNode.ArrToTree(arr);
        KthSmallestElementinaBST kth = new KthSmallestElementinaBST();
        Assert.IsTrue(kth.KthSmallest(root, 3) == 3);
    }

    [TestMethod]
    public void ValidateBinarySearchTree2Test()
    {
        int?[] arr = new int?[] { 2, 2 };
        var root = TreeNode.ArrToTree(arr);
        bool res = ValidateBinarySearchTree2.IsValidBST(root);
        Assert.IsTrue(res == false);
    }

    [TestMethod]
    public void NumberOfIslandsBFSTest()
    {
        char[][] input = {
                new char[] { '1','1','1','1','0'},
                new char[] { '1','1','0','1','0' },
                new char[] { '1','1','0','0','0' },
                new char[] { '0','0','0','0','0' }};
        NumberOfIslands2 sol = new NumberOfIslands2();
        int res = sol.NumIslands(input);
        Assert.IsTrue(res == 1);
    }

    [TestMethod]
    public void SurroundedRegionsTest()
    {
        char[][] input = {
                new char[] { 'X','X','X','X'},
                new char[] { 'X','O','O','X' },
                new char[] { 'X','X','O','X' },
                new char[] { 'X','O','X','X' }};
        SurroundedRegions regions = new SurroundedRegions();
        regions.Solve(input);

        char[][] anss = {
                new char[] { 'X','X','X','X'},
                new char[] { 'X','X','X','X' },
                new char[] { 'X','X','X','X' },
                new char[] { 'X','O','X','X' }};

        Assert.IsTrue(AreJaggedArraysEqual(input, anss));
    }

    [TestMethod]
    public void EvaluateDivision()
    {
        //= [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]

        IList<IList<string>> equations = new List<IList<string>>();
        equations.Add(new List<string>() { "a", "b" });
        equations.Add(new List<string>() { "b", "c" });
        double[] values = new double[] { 2.0, 3.0 };

        IList<IList<string>> queries = new List<IList<string>>();
        queries.Add(new List<string>() { "a", "c" });
        queries.Add(new List<string>() { "b", "a" });
        queries.Add(new List<string>() { "a", "e" });
        queries.Add(new List<string>() { "a", "a" });
        queries.Add(new List<string>() { "x", "x" });

        EvaluateDivision eva = new EvaluateDivision();
        double[] res = eva.CalcEquation(equations, values, queries);
        double[] ans = new double[] { 6.00000, 0.50000, -1.00000, 1.00000, -1.00000 };
        bool e = res.Equals(ans);
        for (int i = 0; i < res.Length; i++)
        {
            if (res[i] != ans[i])
            {
                Assert.Fail();
            }
        }
        // Assert.AreEqual(res, ans);
    }

    [TestMethod]
    public void CourseSchedule2Test()
    {
        //= [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]

        int numCourses = 5;
        int[][] prerequisites = { new int[] { 2, 0 }, new int[] { 2, 1 }, new int[] { 4, 2 }, new int[] { 4, 3 } };
        CourseSchedule2 cs = new CourseSchedule2();
        bool res = cs.CanFinish(numCourses, prerequisites);
        // Assert.AreEqual(res, ans);
    }

    [TestMethod]
    public void CourseScheduleIITest()
    {
        //= [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]

        int numCourses = 2;
        int[][] prerequisites = { new int[] { 0, 1 } };
        CourseScheduleII cs = new CourseScheduleII();
        var res = cs.FindOrder(numCourses, prerequisites);
        int[] ans1 = { 1, 0 };

        Assert.IsTrue(res.SequenceEqual(ans1));
    }

    [TestMethod]
    public void SnakesAndLaddersTest()
    {
        //= [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]
        int[][] board = new int[][]{
            new int[]{-1,-1,-1,-1,-1,-1},
            new int[]{-1,-1,-1,-1,-1,-1},
            new int []{-1,-1,-1,-1,-1,-1},
          new int[]   {-1,35,-1,-1,13,-1},
          new int[]{-1,-1,-1,-1,-1,-1},
          new int[]{-1,15,-1,-1,-1,-1}
        };
        SnakesAndLadders snakes = new SnakesAndLadders();

        Assert.IsTrue(snakes.Steps(board) == 4);
    }

    [TestMethod]
    public void MinimumGeneticMutationTest()
    {
        //= [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]
        string startGene = "AACCGGTT"; string endGene = "AAACGGTA";
        string[] bank = new string[] { "AACCGGTA", "AACCGCTA", "AAACGGTA" };
        MinimumGeneticMutation sol = new MinimumGeneticMutation();
        int times = sol.MinMutation(startGene, endGene, bank);

        Assert.IsTrue(times == 2);
    }

    [TestMethod]
    public void WordLadderTest()
    {
        string beginWord = "hit";
        string endWord = "cog";
        List<string> wordList = new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" };

        WordLadder ladder = new WordLadder();
        Assert.IsTrue(ladder.LadderLength(beginWord, endWord, wordList) == 5);
    }

    [TestMethod]
    public void DesignAddandSearchWordsDataStructureTest()
    {
        WordDictionary2 dictionary = new WordDictionary2();
        dictionary.AddWord("bad");
        dictionary.AddWord("dad");
        dictionary.AddWord("mad");
        Assert.IsFalse(dictionary.Search("pad")); // return False
        Assert.IsTrue(dictionary.Search("bad")); // return True
        Assert.IsTrue(dictionary.Search(".ad")); // return True
        Assert.IsTrue(dictionary.Search("b..")); // return True

    }

    [TestMethod]
    public void WordSearchTest()
    {
        string word = "ABCCED";
        char[][] board = new char[][] { new char[] { 'A', 'B', 'C', 'E' }, new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } };
        WordSearch2 solution = new WordSearch2();

        Assert.IsTrue(solution.Exist(board, word));
    }

    [TestMethod]
    public void WordSearchIITest()
    {
        string[] words = new string[] { "oath", "pea", "eat", "rain" };
        char[][] board = new char[][] { new char[] { 'o','a','a','n' },
                                         new char[] { 'e','t','a','e' },
                                         new char[] { 'i','h','k','r'} ,
                                         new char[] { 'i','f','l','v'} };
        WordSearchII solution = new WordSearchII();
        var res = solution.FindWords(board, words);
    }

    [TestMethod]
    public void WordSearchII2Test()
    {
        string[] words = new string[] { "aaa" };
        char[][] board = new char[][] { new char[] { 'a', 'a' } };
        WordSearchII solution = new WordSearchII();
        var res = solution.FindWords(board, words);
    }

    [TestMethod]
    public void LongestCommonSubsequenceTest()
    {
        LongestCommonSubsequence longest = new LongestCommonSubsequence();
        string text1 = "abcde";
        string text2 = "ace";
        Assert.IsTrue(longest.Longest(text1, text2) == 3);
    }

    // Untility for check two int[][] are equal.
    public static bool AreJaggedArraysEqual<T>(T[][] array1, T[][] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length != array2[i].Length)
            {
                return false;
            }

            for (int j = 0; j < array1[i].Length; j++)
            {
                if (!EqualityComparer<T>.Default.Equals(array1[i][j], array2[i][j]))
                {
                    return false;
                }
            }
        }
        return true;
    }

    static bool AreListsEqual<T>(IList<IList<T>> list1, IList<IList<T>> list2)
    {
        if (list1.Count != list2.Count)
            return false;

        for (int i = 0; i < list1.Count; i++)
        {
            IList<T> innerList1 = list1[i];
            IList<T> innerList2 = list2[i];

            if (innerList1.Count != innerList2.Count || !innerList1.SequenceEqual(innerList2))
                return false;
        }

        return true;
    }
}

internal class T
{
}