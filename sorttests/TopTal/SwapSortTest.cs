using Algo.TopTal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.TopTal
{
    [TestClass]
    public class SwapSortTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new SwapSort();

            var result = algo.solution(new[] { 1 });
            Assert.IsTrue(result);

            result = algo.solution(new[] {1, 1, 1});
            Assert.IsTrue(result);

            result = algo.solution(new[] {1, 5, 3, 3, 7});
            Assert.IsTrue(result);

            result = algo.solution(new[] {1, 3, 5});
            Assert.IsTrue(result);

            result = algo.solution(new[] {1, 3, 5, 3, 4});
            Assert.IsFalse(result);

            result = algo.solution(new[] {1, 3, 3, 7, 7, 5, 8, 8, 10});
            Assert.IsTrue(result);
        }
    }
}
