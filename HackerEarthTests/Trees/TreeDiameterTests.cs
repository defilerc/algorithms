using HackerEarth;
using HackerEarth.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerEarthTests.Trees
{
    [TestClass]
    public class TreeDiameterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var troot = new Tree(1) {
                left = new Tree(2) {
                    left = new Tree(3),
                    right = new Tree(4) {
                        left = new Tree(5),
                        right = new Tree(6)
                    }
                },
                right = new Tree(7) {
                    right = new Tree(8) {
                        right = new Tree(9) {
                            left = new Tree(10) {
                                right = new Tree(11)
                            },
                            right = new Tree(12)
                        }
                    }
                }
            };

            var result = TreeDiameter.FindTreeDiameter(troot);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var tnoroot = new Tree(1) {
                left = new Tree(2) {
                    left = new Tree(3) {
                        left = new Tree(4),
                        right = new Tree(5) {
                            left = new Tree(6) {
                                right = new Tree(7)
                            }
                        }
                    },
                    right = new Tree(8) {
                        right = new Tree(9) {
                            left = new Tree(10),
                            right = new Tree(11) {
                                left = new Tree(12)
                            }
                        }
                    }
                },
                right = new Tree(13)
            };

            var result = TreeDiameter.FindTreeDiameter(tnoroot);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var tree = new Tree(1) {
                left = new Tree(2) {
                    left = new Tree(4),
                    right = new Tree(5)
                },
                right = new Tree(3)
            };

            var result = TreeDiameter.FindTreeDiameter(tree);
        }
    }
}
