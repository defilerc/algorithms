using System;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class ChristmasThiefTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new ChristmasThiefAlgo();
            var result = algo.christmasThief(new string[][] {
                new[] {"Bill", "Rob"},
                new[] {"Matt", "Jane"},
                new[] {"Jane", "Matt"}
            });
        }
    }
}
