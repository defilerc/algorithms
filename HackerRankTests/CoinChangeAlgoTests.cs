using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests
{
    [TestClass]
    public class CoinChangeAlgoTests
    {
        [TestMethod]
        public void CoinChangeAlgoTest()
        {
            var algo = new CoinChangeAlgo();
            var result = algo.getWays(4, new long[] {1, 2, 3});
        }
    }
}
