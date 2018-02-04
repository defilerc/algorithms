using Daily.Jan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests.Jan
{
    [TestClass]
    public class SubsetGcdTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new SubsetGcdAlgo();

            var result = algo.subsetGcd(100000, 1);
             Assert.AreEqual(77183281, result);
        }
    }
}
