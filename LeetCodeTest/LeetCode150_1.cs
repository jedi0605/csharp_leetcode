using LeetCodeLib;

namespace LeetCodeTest;

[TestClass]
public class LeetCode150_1
{
    [TestMethod]
    public void MergeSortedArrayTest()
    {
        int[] nums1 =new int[] {1,2,3,0,0,0};
        int m=3;

        int[] nums2 =new int[] {2,5,6};
        int n=3;
        

        MergeSortedArray mergeSorted = new MergeSortedArray();
        // mergeSorted.MergeBF(nums1,m,nums2,n);

        mergeSorted.Merge(nums1,m,nums2,n);
    }
}