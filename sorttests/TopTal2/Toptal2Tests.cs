using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algo.TopTal2
{
    [TestClass]
    public class Toptal2Tests
    {
        [TestMethod]
        public void Test1()
        {
            var algo = new Solution1();

            var tree = new Tree(4) {
                l = new Tree(5) {
                    l = new Tree(4) {
                        l = new Tree(5)
                    }
                },
                r = new Tree(6) {
                    l = new Tree(1) {
                        r = new Tree(6)
                    }
                }
            };

            var result = algo.solution(tree);

            var t2 = new Tree(1) {
                l = new Tree(2) {
                    l = new Tree(3) {
                        l = new Tree(3) {
                            l = new Tree(4) {
                                r = new Tree(5)
                            }
                        }
                    },
                    r = new Tree(3) {
                        l = new Tree(3) {
                            r = new Tree(4) {
                                r = new Tree(5)
                            }
                        },
                        r = new Tree(4)
                    }
                },
                r = new Tree(2) {
                    l = new Tree(3),
                    r = new Tree(3)
                }
            };

            result = algo.solution(t2);
        }

        [TestMethod]
        public void Test2()
        {
            var algo = new Solution2Correct();
            int result = 0;

            result = algo.solution(0);
            result = algo.solution(120);
            result = algo.solution(10);

            result = algo.solution(123);
            
            result = algo.solution(1213);
        }

        [TestMethod]
        public void Test3()
        {
            var algo = new Solution3();

            var result = algo.solution("abbabba");
            result = algo.solution("codility");
        }
    }
}
