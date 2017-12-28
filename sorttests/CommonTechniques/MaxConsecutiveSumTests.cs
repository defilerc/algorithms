using Algo;
using Algo.CommonTechniques;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.CommonTechniques
{
    [TestClass]
    public class MaxConsecutiveSumTests
    {
        [TestMethod]
        public void MaxConsecutiveSum()
        {
            var algo = new MaxConsecutiveSum();
            var kadane = new MaxSubArray();

            var res2 = kadane.arrayMaxConsecutiveSum2(new int[] {1, -2, 3, -4, 5, -3, 2, 2, 2});
            var result = algo.arrayMaxConsecutiveSum2(new int[] {1, -2, 3, -4, 5, -3, 2, 2, 2});

            Assert.AreEqual(8, result);
        }
    }
}
