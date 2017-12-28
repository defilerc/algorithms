using Algo;
using Algo.TopTal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.TopTal
{
    [TestClass]
    public class MaxZigZagTests
    {
        [TestMethod]
        public void MaxZigZag()
        {
            var algo = new MaxZigZag();

            var result = algo.Solution(null);

            result = algo.Solution(new Tree(3));

            result = algo.Solution(new Tree(3) {left = new Tree(1)});

            result = algo.Solution(new Tree(3) { right = new Tree(1) });

            result = algo.Solution(new Tree(3) { left = new Tree(2), right = new Tree(1) });

            result = algo.Solution(new Tree<int>() {
                value = 5,
                left = new Tree<int>() {
                    value = 3,
                    left = new Tree<int>() {
                        value = 20,
                        left = new Tree<int>() {
                            value = 6,
                            left = null,
                            right = null,
                        },
                        right = null
                    },
                    right = null
                },
                right = new Tree<int>() {
                    value = 10,
                    left = new Tree<int>() {
                        value = 1,
                    },
                    right = new Tree<int>() {
                        value = 15,
                        left = new Tree<int>() {
                            value = 30,
                            left = null,
                            right = new Tree<int>() {
                                value = 9
                            }
                        },
                        right = new Tree<int>() {
                            value = 8
                        }
                    }
                }
            });
        }
    }
}
