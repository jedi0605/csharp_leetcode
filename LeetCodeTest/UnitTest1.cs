using LeetCodeLib;

namespace LeetCodeTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        TestCase1 case1 = new TestCase1();
        int sum = case1.AddSum(1, 2);

        Assert.IsTrue(sum == 3);
    }
}