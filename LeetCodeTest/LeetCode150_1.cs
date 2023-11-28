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
        int[] nums = { 1, 2, 3, 4, 5, 6};
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
}