using System;
using Daily.Feb;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests.Feb
{
    [TestClass]
    public class CommonPointsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new CommonPointsAlgo();
            var result = algo.commonPoints(1, 5, 2, 10);
        }
    }
}
