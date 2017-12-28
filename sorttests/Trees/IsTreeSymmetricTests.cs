using Algo;
using Algo.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Trees
{
    [TestClass]
    public class IsTreeSymmetricTests
    {
        [TestMethod]
        public void IsTreeSymmetric()
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

            var algo = new IsTreeSymmetric();

            var result = algo.isTreeSymmetric(tree);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsTreeSymmetric2()
        {
            var t = new Tree<int> {
                value = 1,
                left = new Tree<int> {
                    value = 2,
                    left = new Tree<int> {
                        value = 3,
                        left = null,
                        right = null
                    },
                    right = new Tree<int> {
                        value = 4,
                        left = null,
                        right = null
                    }
                },
                right = new Tree<int> {
                    value = 2,
                    left = new Tree<int> {
                        value = 4,
                        left = null,
                        right = null
                    },
                    right = new Tree<int> {
                        value = 3,
                        left = null,
                        right = null
                    }
                }
            };

            var algo = new IsTreeSymmetric();

            var result = algo.isTreeSymmetric(t);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsTreeSymmetric3()
        {
            var t =  new Tree<int> {
                value= 1,
                left=  new Tree<int>{
                    value= 2,
                    left= null,
                    right=  new Tree<int>{
                        value= 3,
                        left= null,
                        right= null
                    }
                },
                right=  new Tree<int>{
                    value= 2,
                    left= null,
                    right=  new Tree<int>{
                        value= 3,
                        left= null,
                        right= null
                    }
                }
            };

            var algo = new IsTreeSymmetric();

            var result = algo.isTreeSymmetric(t);
            Assert.IsFalse(result);

        }
    }
}
