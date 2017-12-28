using Algo.Backtracking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Backtracking
{
    [TestClass]
    public class CombinationSumTests
    {
        [TestMethod]
        public void CombinationSum()
        {
            var algo = new CombinationSum();
            var a = new [] {2, 3, 5, 9};
            var sum = 9;

            var result = algo.combinationSum(a, sum);

            //combinationSum(a, sum) = "(2 2 2 3)(2 2 5)(3 3 3)(9)".
        }
    }
}
