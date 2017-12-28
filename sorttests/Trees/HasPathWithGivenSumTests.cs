using System;
using Algo;
using Algo.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Trees
{
    [TestClass]
    public class HasPathWithGivenSumTests
    {
        [TestMethod]
        public void HasPathWithGivenSum()
        {
            var tree = new Tree<int> {
                value = 4,
                left = new Tree<int> {
                    value = 1,
                    left = new Tree<int> {
                        value = -2,
                        left = null,
                        right = new Tree<int> {
                            value = 3,
                            left = null,
                            right = null
                        }
                    },
                    right = null
                },
                right = new Tree<int> {
                    value = 3,
                    left = new Tree<int> {
                        value = 1,
                        left = null,
                        right = null
                    },
                    right = new Tree<int> {
                        value = 2,
                        left = new Tree<int> {
                            value = -4,
                            left = null,
                            right = null
                        },
                        right = new Tree<int> {
                            value = -3,
                            left = null,
                            right = null
                        }
                    }
                }
            };

            var algo = new HasPathWithGivenSum();

            var result = algo.hasPathWithGivenSum(tree, 7);

            Assert.IsFalse(result);
        }
    }
}
