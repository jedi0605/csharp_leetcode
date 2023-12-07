using System.Data;
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
}