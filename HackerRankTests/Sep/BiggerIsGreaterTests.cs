using HackerRank.Sep;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Sep
{
    [TestClass]
    public class BiggerIsGreaterTests
    {
        [TestMethod]
        public void Test1()
        {
            var algo = new BiggerIsGreaterAlgo();

            var perms = algo.Perms("03358");
        }
    }
}
