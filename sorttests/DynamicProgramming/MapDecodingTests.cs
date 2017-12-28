using Algo.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.DynamicProgramming
{
    [TestClass]
    public class MapDecodingTests
    {
        [TestMethod]
        public void MapDecoding()
        {
            var algo = new MapDecodingAlgo();
            var result = algo.mapDecoding("11115112112");
            Assert.AreEqual(5, result);
        }
    }
}
