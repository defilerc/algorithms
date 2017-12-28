using Algo.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.DynamicProgramming
{
    [TestClass]
    public class ClimbingStairsTests
    {
        [TestMethod]
        public void ClimbingStairs()
        {
            var algo = new ClimbingStairsAlgo();
            var result = algo.climbingStairs(5);
        }
    }
}
