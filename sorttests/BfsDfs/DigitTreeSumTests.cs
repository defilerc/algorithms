using System;
using Algo;
using Algo.BfsDfs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.BfsDfs
{
    [TestClass]
    public class DigitTreeSumTests
    {
        [TestMethod]
        public void DigitTreeSumTest()
        {
            var t = new Tree<int> {
                value = 1,
                left = new Tree<int> {
                    value = 0,
                    left = new Tree<int> {
                        value = 3,
                        left = null,
                        right = null
                    },
                    right = new Tree<int> {
                        value = 1,
                        left = null,
                        right = null
                    }
                },
                right = new Tree<int> {
                    value = 4,
                    left = null,
                    right = null
                }
            };

            var algo = new DigitTreeSumAlgo();
            var result = algo.digitTreeSum(t);
        }
    }
}
