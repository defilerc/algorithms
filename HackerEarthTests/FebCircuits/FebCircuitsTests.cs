using HackerEarth.FebCircuits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerEarthTests.FebCircuits
{
    [TestClass]
    public class FebCircuitsTests
    {
        [TestMethod]
        public void Problem1Test()
        {
            var algo = new Problem1();

            var result = algo.Solve(new[] {2.0000, 3.0000, 4.0000}, new[] {35, 25, 35});
        }
    }
}
