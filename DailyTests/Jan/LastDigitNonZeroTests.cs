using System;
using Daily.Jan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests.Jan
{
    [TestClass]
    public class LastDigitNonZeroTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new LastDigitNonZero();
            var result = algo.lastDigitDiffZero(26);
        }
    }
}
