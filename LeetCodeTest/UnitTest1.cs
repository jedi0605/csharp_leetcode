using LeetCodeLib;

namespace LeetCodeTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TwoSumTest1()
    {
        int[] nums = new int[] { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum.Run(nums, target);

        int verify = nums[result[0]] + nums[result[1]];
        Assert.IsTrue(verify == target);
    }

    [TestMethod]
    public void TwoSumTest2()
    {
        int[] nums = new int[] { 3, 2, 4 };
        int target = 6;
        int[] result = TwoSum.Run(nums, target);

        int verify = nums[result[0]] + nums[result[1]];
        Assert.IsTrue(verify == target);
    }

    [TestMethod]
    public void TwoSumTest3()
    {
        int[] nums = new int[] { 3, 3 };
        int target = 6;
        int[] result = TwoSum.Run(nums, target);

        int verify = nums[result[0]] + nums[result[1]];
        Assert.IsTrue(verify == target);
    }

    [TestMethod]
    public void ValidParenthesesTest()
    {
        string testCase = "()[]{}";
        bool result = ValidParentheses.IsValid(testCase);
        Assert.IsTrue(result);
    }


    [TestMethod]
    public void ValidParenthesesTest2()
    {
        string testCase = "(]";
        bool result = ValidParentheses.IsValid(testCase);
        Assert.IsTrue(result == false);
    }


    [TestMethod]
    public void MergeTwoSortedListsTest1()
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode head2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        // ListNode reuslt = MergeTwoSortedLists.MergeTwoLists(head, head2);
        Assert.IsTrue(head.Equals(head2) == false);
    }

    [TestMethod]
    public void MergeTwoSortedListsTest2()
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode head2 = new ListNode(1, new ListNode(2, new ListNode(4)));

        // ListNode reuslt = MergeTwoSortedLists.MergeTwoLists(head, head2);
        Assert.IsTrue(head.Equals(head2) == true);
    }

    [TestMethod]
    public void MergeTwoSortedListsTest3()
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode head2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        ListNode reuslt = MergeTwoSortedLists.MergeTwoLists(head, head2);

        ListNode answer = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

        Assert.IsTrue(reuslt.Equals(answer) == true);
    }

    [TestMethod]
    public void BestTime2BuyAndSellStockTest()
    {
        int[] array = new int[] { 7, 1, 5, 3, 6, 4 };
        int result = 5;
        int profit = BestTime2BuyAndSellStock.MaxProfit(array);
        Assert.IsTrue(result == profit);
    }

    [TestMethod]
    public void BestTime2BuyAndSellStockTest2()
    {
        int[] array = new int[] { 7, 6, 4, 3, 1 };
        int result = 0;
        int profit = BestTime2BuyAndSellStock.MaxProfit(array);
        Assert.IsTrue(result == profit);
    }

    [TestMethod]
    public void ValidPalindromeTest()
    {
        string input = "A man, a plan, a canal: Panama";

        bool IsPalindrome = ValidPalindrome.IsPalindrome(input);
        bool answer = true;
        Assert.IsTrue(IsPalindrome == answer);

        string input2 = "race a car";
        bool IsPalindrome2 = ValidPalindrome.IsPalindrome(input2);
        bool answer2 = false;
        Assert.IsTrue(IsPalindrome2 == answer2);

         string input3 = "A man, a plan, a canal -- Panama";
        bool IsPalindrome3 = ValidPalindrome.IsPalindrome(input3);
        bool answer3 = true;
        Assert.IsTrue(IsPalindrome3 == answer3);



    }
}