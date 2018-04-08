using System;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class SumBelowBoundTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new SumBelowBound();
            algo.sumBelowBound(14);
        }
    }
}
