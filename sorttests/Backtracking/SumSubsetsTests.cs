using Algo.Backtracking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Backtracking
{
    [TestClass]
    public class SumSubsetsTests
    {
        [TestMethod]
        public void SumSubsets()
        {
            var algo = new SumSubsetsAlgo();
            var result = algo.sumSubsets(new[] {1,1}, 0);
        }
    }
}
