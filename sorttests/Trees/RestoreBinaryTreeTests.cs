using Algo.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Trees
{
    [TestClass]
    public class RestoreBinaryTreeTests
    {
        [TestMethod]
        public void RestoreBinaryTreeTest()
        {
            int[] inorder;
            int[] preorder;

            var algo = new RestoreBinaryTree();

            //inorder = new[] {3, 2, 1};
            //preorder = new[] {1, 2, 3};
            
            //inorder = new[] { 1, 2, 3 };
            //preorder = new[] { 1, 2, 3 };

            inorder = new[] {4, 2, 1, 5, 3, 6};
            preorder = new[] {1, 2, 4, 3, 5, 6};

            inorder = new[] {4, 2, 7, 1, 5, 3, 6};
            preorder = new[] {1, 2, 4, 7, 3, 5, 6};

            var tree = algo.restoreBinaryTree(inorder, preorder);
        }
    }
}
