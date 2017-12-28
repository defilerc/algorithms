using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Trees
{
    [TestClass]
    public class DeleteFromBSTTests
    {
        [TestMethod]
        public void DeleteFromBST()
        {
            var algo = new DeleteFromBST();

            var t = new Tree<int>() {
                value = 3,
                left = new Tree<int>() {
                    value = 2,
                    left = new Tree<int>() {
                        value = 1,
                        left = null,
                        right = null
                    },
                    right = null
                },
                right = new Tree<int>() {
                    value = 5,
                    left = null,
                    right = null
                }
            };
            
            var result = algo.deleteFromBST(t, new[] {3, 2, 1});
        }
    }
}
