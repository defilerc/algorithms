using Algo.ToptalSampleInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.ToptalSampleInterviewTests
{
    [TestClass]
    public class ToptalSampleInterviewTests
    {
        [TestMethod]
        public void Test1()
        {
            var algo = new ToptalSampleInterview();
            var result = algo.remove("foo bar foo $ bar $ foo bar $ ");
            var result2 = algo.removeRegex("foo bar foo $ bar $ foo bar $ ");

            Assert.AreEqual(result, result2);
        }
    }
}
