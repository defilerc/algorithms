using Daily.Feb;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests.Feb
{
    [TestClass]
    public class NckSumTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new NckSumAlgo();
            var result2 = algo.nckSumShort(10, 3);
            var result = algo.nckSumShort(5, 2);
            
        }
    }
}
