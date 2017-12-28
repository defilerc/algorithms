using Algo.Backtracking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Backtracking
{
    [TestClass]
    public class ClimbingStaircaseTests
    {
        [TestMethod]
        public void ClimbingStaircase()
        {
            var algo = new ClimbingStaircaseAlgo();
            var result = algo.climbingStaircase(4, 2);
        }
    }
}
