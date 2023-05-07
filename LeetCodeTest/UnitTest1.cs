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

    [TestMethod]
    public void InvertBinaryTreeTest()
    {
        TreeNode root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));
        TreeNode root2 = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));
        Assert.IsTrue(InvertBinaryTree.CompareTrees(root, root2));
        TreeNode root3 = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));
        TreeNode root4 = new TreeNode(9, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));
        Assert.IsTrue(InvertBinaryTree.CompareTrees(root3, root4) == false);
    }

    [TestMethod]
    public void InvertBinaryTreeTest2()
    {
        TreeNode root = new TreeNode(2, new TreeNode(1), new TreeNode(3));

        TreeNode invert = InvertBinaryTree.InvertTree(root);
        TreeNode target = new TreeNode(2, new TreeNode(3), new TreeNode(1));

        Assert.IsTrue(InvertBinaryTree.Equals(invert, target));
    }

    [TestMethod]
    public void InvertBinaryTreeTest3()
    {
        TreeNode root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));
        InvertBinaryTree.PrintAll(root);
        TreeNode invert = InvertBinaryTree.InvertTree(root);
        System.Diagnostics.Debug.WriteLine("******");
        InvertBinaryTree.PrintAll(invert);
        TreeNode target = new TreeNode(4, new TreeNode(7, new TreeNode(9), new TreeNode(6)), new TreeNode(2, new TreeNode(3), new TreeNode(1)));

        Assert.IsTrue(InvertBinaryTree.CompareTrees(invert, target));
    }

    [TestMethod]
    public void ValidAnagramTest()
    {
        string s = "";
        string t = "";
        Assert.IsTrue(ValidAnagram.IsAnagram(s, t) == true);

        string s1 = "anagram";
        string t1 = "nagaram";
        Assert.IsTrue(ValidAnagram.IsAnagram(s1, t1) == true);

        string s2 = "rat";
        string t2 = "car";
        Assert.IsTrue(ValidAnagram.IsAnagram(s2, t2) == false);

        string s3 = "aacc";
        string t3 = "ccac";
        Assert.IsTrue(ValidAnagram.IsAnagram(s3, t3) == true);
    }

    [TestMethod]
    public void BinarySearchTest()
    {
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        int target = 9;
        int result = 4;
        // int targetIndex = BinarySearch.Search(nums, target);
        int targetIndex = BinarySearch.BinarySearchRecursive(nums, target, nums.Length - 1, 0);
        Assert.IsTrue(targetIndex == result);

        int[] nums2 = { -1, 0, 3, 5, 9, 12 };
        int target2 = 2;
        int result2 = -1;
        //        int targetIndex2 = BinarySearch.Search(nums2, target2);
        int targetIndex2 = BinarySearch.BinarySearchRecursive(nums2, target2, nums2.Length - 1, 0);
        Assert.IsTrue(targetIndex2 == result2);
    }


    [TestMethod]
    public void FloodFillTest()
    {
        int[][] image = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };
        FloodFill.Fill(image, 1, 1, 2);
        int[][] imageExpect = new int[][] { new int[] { 2, 2, 2 }, new int[] { 2, 2, 0 }, new int[] { 2, 0, 1 } };

        bool result = FloodFill.FloodEquals(image, imageExpect);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void FloodFillTest2()
    {
        int[][] image = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } };
        FloodFill.Fill(image, 0, 0, 0);
        int[][] imageExpect = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } };

        bool result = FloodFill.FloodEquals(image, imageExpect);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void BinaryTreeInsertTest()
    {
        int?[] array = { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
        BinaryTree binaryTree = new BinaryTree(array);
        System.Diagnostics.Debug.WriteLine("In-Order Traversal:");
        binaryTree.InOrderTraversal(binaryTree.root);
    }

    [TestMethod]
    public void LowestCommonAncestorTest()
    {
        int?[] array = { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
        BinaryTree binaryTree = new BinaryTree(array);

        TreeNode ancestor = LowestCommonAncestor.Solution(binaryTree.root, new TreeNode(2), new TreeNode(8));
        Assert.IsTrue(ancestor.val == 6);

        TreeNode ancestor2 = LowestCommonAncestor.Solution(binaryTree.root, new TreeNode(2), new TreeNode(4));
        Assert.IsTrue(ancestor2.val == 2);

    }


    [TestMethod]
    public void BalancedBinaryTreeTest()
    {
        int?[] array = { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
        BinaryTree binaryTree = new BinaryTree(array);

        int GetTreeHight = BalancedBinaryTree.GetTreeHight(binaryTree.root);
        Assert.IsTrue(GetTreeHight == 4);
    }


    [TestMethod]
    public void BalancedBinaryTreeTest2()
    {
        int?[] array2 = { 1, 2, 2, 3, 3, null, null, 4, 4 };
        BinaryTree binaryTree2 = new BinaryTree(array2);
        int height = BalancedBinaryTree.GetTreeHight(binaryTree2.root);
        bool result3 = BalancedBinaryTree.IsBalance(binaryTree2.root);
        Assert.IsTrue(result3 == false);

        int?[] array = { 3, 9, 20, null, null, 15, 7 };
        BinaryTree binaryTree = new BinaryTree(array);
        int GetTreeHight = BalancedBinaryTree.GetTreeHight(binaryTree.root);
        bool result = BalancedBinaryTree.IsBalance(binaryTree.root);
        Assert.IsTrue(GetTreeHight == 3);
        Assert.IsTrue(result);


        // int GetTreeHight2 = BalancedBinaryTree.GetTreeHight(binaryTree2.root);
        TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(3, new TreeNode(4), new TreeNode(4)), new TreeNode(3)), new TreeNode(2));
        bool result2 = BalancedBinaryTree.IsBalance(root);
        Assert.IsTrue(result2 == false);
    }

    [TestMethod]
    public void LinkedListCycleTest()
    {
        ListNode head = new ListNode(3);
        ListNode two = new ListNode(2);
        head.next = two;
        ListNode  three = new ListNode(0);
        two.next = three;
        ListNode four = new ListNode(-4);
        three.next = four;

        four.next = two;
        bool hasCycle =  LinkedListCycle.HasCycle(head);        
        Assert.IsTrue(hasCycle);
    }

    [TestMethod]
    public void LinkedListCycleTest2()
    {
        ListNode head = new ListNode(1);
        ListNode two = new ListNode(2);
        head.next = two;
        
        bool hasCycle =  LinkedListCycle.HasCycle(head);        
        Assert.IsTrue(hasCycle);
    }
}