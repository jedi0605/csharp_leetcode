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

}