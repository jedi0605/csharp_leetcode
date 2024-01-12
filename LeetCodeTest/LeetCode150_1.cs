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
        int[][] input = new int[][] { new int[] { 1}, new int[]{2}, new int[]{3},new int[]{4}};
        IList<int> res = SpiralMatrix2.SpiralOrder(input);
        List<int> ans = new List<int>() { 1, 2, 3, 4 };
        Assert.IsTrue(res.SequenceEqual(ans));
    }
}