using System;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class HugeNumberTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new HugeNumber();
            var result = algo.hugeNumber(new [] {"20", "3005", "2"});
            Assert.AreEqual("3005220", result);
        }
    }
}
