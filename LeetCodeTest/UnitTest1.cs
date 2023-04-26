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
}