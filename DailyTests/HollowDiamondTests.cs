using System;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class HollowDiamondTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new HollowDiamond();
            var result = algo.hollowDiamond(3);
        }
    }
}
