using Algo.CommonTechniques;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.CommonTechniques
{
    [TestClass]
    public class SumInRangeTests
    {
        [TestMethod]
        public void SumInRange()
        {
            var algo = new SumInRange();
            var result = algo.sumInRange(new [] {3, 0, -2, 6, -3, 2}, new int[][] {
                new [] {0, 2},
                new [] {2, 5},
                new [] {0, 5}
            });

            Assert.AreEqual(10, result);
        }
    }
}
