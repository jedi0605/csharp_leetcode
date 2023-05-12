using LeetCodeLib;

namespace LeetCodeTest;

[TestClass]
public class UnitTest2
{
    [TestMethod]
    public void Template()
    {
        int?[] root = { 1, 2, 3, 4, 5 };
        BinaryTree tree = new BinaryTree(root);
        tree.InOrderTraversal(tree.root);
    }

    [TestMethod]
    public void MiddleNodeTest()
    {
        ListNode root = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode middle = MiddleOfLinkedList.MiddleNode(root);


        ListNode answerNode = new ListNode(3,new ListNode(4,new ListNode(5)));
        Assert.IsTrue(middle.Equals(answerNode));

    }

}