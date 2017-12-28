using System;
using Algo.DynamicProgrammingAdvanced;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.DynamicProgrammingAdvanced
{
    [TestClass]
    public class LongestIncreasingSubsequenceTests
    {
        [TestMethod]
        public void LongestIncreasingSubsequence()
        {
            var algo = new LongestIncreasingSubsequence();
            var result = algo.longestIncreasingSubsequence(new []{ 1, 231, 2, 4, 89, 32, 12, 234, 33, 90, 34, 100 });
            Assert.AreEqual(7, result);

            result = algo.longestIncreasingSubsequence(new []{ 1, 231, 2, 4, 89, 32, 12, 234, 33, 90, 34, 42, 88, 15, 16, 100 });
            Assert.AreEqual(9, result);

            result = algo.longestIncreasingSubsequence(new[]{45, 40, 27, 24, 38, 39, 19, 83, 30, 42, 34, 16, 40, 59});
            Assert.AreEqual(5, result);
        }
    }
}
