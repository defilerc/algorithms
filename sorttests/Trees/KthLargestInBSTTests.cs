using System;
using Algo;
using Algo.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Trees
{
    [TestClass]
    public class KthLargestInBSTTests
    {
        [TestMethod]
        public void KthLargestInBST()
        {
            var algo = new KthLargestInBST();

            var result = algo.kthLargestInBST(new Tree<int>() {value = 5}, 1);

            Assert.AreEqual(5, result);

            var tree = new Tree<int> {
                value = 3,
                left = new Tree<int> {
                    value = 1,
                    left = null,
                    right = null
                },
                right = new Tree<int> {
                    value = 5,
                    left = new Tree<int> {
                        value = 4,
                        left = null,
                        right = null
                    },
                    right = new Tree<int> {
                        value = 6,
                        left = null,
                        right = null
                    }
                }
            };

            result = algo.kthLargestInBST(tree, 3);
            Assert.AreEqual(4, result);
        }
    }
}
