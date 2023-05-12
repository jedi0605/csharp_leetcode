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

}