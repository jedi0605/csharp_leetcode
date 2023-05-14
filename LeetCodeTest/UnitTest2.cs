using LeetCodeLib;

namespace LeetCodeTest;

[TestClass]
public class UnitTest2
{
    [TestMethod]
    public void DiameterOfBinaryTreeTest()
    {
        int?[] root = { 1, 2, 3, 4, 5 };
        BinaryTree tree = new BinaryTree(root);
        Assert.IsTrue(DiameterOfBinaryTree.GetDiameterOfTree(tree.root) == 3);
    }

    [TestMethod]
    public void DiameterOfBinaryTreeTest2()
    {
        int?[] root = { 1, 2 };
        BinaryTree tree = new BinaryTree(root);
        Assert.IsTrue(DiameterOfBinaryTree.GetDiameterOfTree(tree.root) == 1);
    }

    [TestMethod]
    public void MiddleNodeTest()
    {
        ListNode root = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode middle = MiddleOfLinkedList.MiddleNode(root);


        ListNode answerNode = new ListNode(3, new ListNode(4, new ListNode(5)));
        Assert.IsTrue(middle.Equals(answerNode));

    }

    [TestMethod]
    public void MaximumDepthOfBinaryTreeTest()
    {
        int?[] array = { 3, 9, 20, null, null, 15, 7 };
        BinaryTree tree = new BinaryTree(array);
        Assert.IsTrue(MaximumDepthOfBinaryTree.MaxDepth(tree.root) == 3);
    }

    [TestMethod]
    public void ContainsDuplicateTest()
    {
        int[] array = { 1, 2, 3, 1 };
        Assert.IsTrue(ContainsDuplicate.CheckDuplicate(array) == true);

        int[] array2 = { 1, 2, 3, 4 };
        Assert.IsTrue(ContainsDuplicate.CheckDuplicate(array2) == false);
    }

    [TestMethod]
    public void RomanToIntegerTest()
    {
        Assert.IsTrue(RomanToInt.ConvertToInt("III") == 3);
        Assert.IsTrue(RomanToInt.ConvertToInt("LVIII") == 58);
        Assert.IsTrue(RomanToInt.ConvertToInt("MCMXCIV") == 1994);

    }

    [TestMethod]
    public void RomanToInteger2Test()
    {
        Assert.IsTrue(RomanToInt.ConvertToInt2("III") == 3);
        Assert.IsTrue(RomanToInt.ConvertToInt2("LVIII") == 58);
        Assert.IsTrue(RomanToInt.ConvertToInt2("MCMXCIV") == 1994);
    }


    [TestMethod]
    public void BackspaceStringCompareTest()
    {
        string s = "ab#c";
        string t = "ad#c";
        Assert.IsTrue(BackspaceCompare.Compare(s, t) == true);
    }

    [TestMethod]
    public void BackspaceStringCompareTest2()
    {
        string s = "a#c";
        string t = "b";
        Assert.IsTrue(BackspaceCompare.Compare(s, t) == false);
    }

    [TestMethod]
    public void BackspaceStringCompareTest3()
    {
        string s = "ab##";
        string t = "c#d#";
        Assert.IsTrue(BackspaceCompare.Compare(s, t) == true);
    }

    [TestMethod]
    public void BackspaceStringCompareTest4()
    {
        string s = "a##c";
        string t = "#a#c";
        Assert.IsTrue(BackspaceCompare.Compare(s, t) == true);
    }

    [TestMethod]
    public void BackspaceStringCompareTest5()
    {
        string s = "y#fo##f";
        string t = "y#f#o##f";
        Assert.IsTrue(BackspaceCompare.Compare(s, t) == false);
    }

    [TestMethod]
    public void CounteBitsTest()
    {
        int n = 5;
        int[] result = { 0, 1, 1, 2, 1, 2 };
        Assert.IsTrue(CountBits.CountBit(n).SequenceEqual(result));
    }

    [TestMethod]
    public void CounteBitsTest2()
    {
        int n = 2;
        int[] result = { 0, 1, 1 };
        Assert.IsTrue(CountBits.CountBit(n).SequenceEqual(result));
    }

    [TestMethod]
    public void NumberOfOneBitTest()
    {
        uint n = 00000000000000000000000000001011;
        Assert.IsTrue(NumberOfOneBit.HammingWeight2(n) == 3);
    }

    [TestMethod]
    public void LongestCommonPrefixTest()
    {
        string[] input = { "flower", "flow", "flight" };
        string[] input2 = { "dog", "racecar", "car" };
        Assert.IsTrue(LongestCommonPrefix.GetCommonPrefix(input) == "fl");
        Assert.IsTrue(LongestCommonPrefix.GetCommonPrefix(input2) == "");
    }

    [TestMethod]
    public void SingleNumberTest()
    {
        int[] nums = { 2, 2, 1 };
        Assert.IsTrue(SingleNumber.GetSingleNumber(nums) == 1);
    }

    [TestMethod]
    public void PalindromeLinkedListTest()
    {
        ListNode root = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
        Assert.IsTrue(PalindromeLinkedList.IsPalindrome(root) == true);
    }
    [TestMethod]
    public void PalindromeLinkedListTest2()
    {
        ListNode root = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        // ListNode reverse = PalindromeLinkedList._ReverseLinkedList(root);

        Assert.IsTrue(PalindromeLinkedList.IsPalindromeQuickSlow(root) == false);
        ListNode root2 = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
        Assert.IsTrue(PalindromeLinkedList.IsPalindromeQuickSlow(root2) == true);
    }
}