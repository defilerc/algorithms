using Algo.Backtracking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Backtracking
{
    [TestClass]
    public class NQueensTests
    {
        [TestMethod]
        public void NQueensTest()
        {
            var algo = new NQueensAlgo();
            var result = algo.nQueens(4);
        }
    }
}
