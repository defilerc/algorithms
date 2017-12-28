using System;
using Algo.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.DynamicProgramming
{
    [TestClass]
    public class ComposeRangesTest
    {
        [TestMethod]
        public void ComposeRanges()
        {
            var algo = new ComposeRangesAlgo();
            var result = algo.composeRanges(new[] {-1, 0, 1, 2, 6, 7, 9});
        }
    }
}
