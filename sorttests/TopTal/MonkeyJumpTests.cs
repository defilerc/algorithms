using Algo.TopTal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.TopTal
{
    [TestClass]
    public class MonkeyJumpTests
    {
        [TestMethod]
        public void MonkeyJump()
        {
            var algo = new MonkeyJump();

            var result = algo.Solution(null, 3);
            Assert.AreEqual(-1, result);

            result = algo.Solution(new int[] { }, 3);
            Assert.AreEqual(-1, result);

            result = algo.Solution(new[] {1, -1, 0, 2, 3, 5}, 3);
            Assert.AreEqual(2, result);

            result = algo.Solution(new[] {3, 2, 1}, 1);
            Assert.AreEqual(3, result);

            result = algo.Solution(new[] {1,2,3,4,-1,-1,-1}, 3);
            Assert.AreEqual(-1, result);
        }
    }
}
