using Algo.Toptal2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.TopTal2
{
    [TestClass]
    public class Algo1Tests
    {
        [TestMethod]
        public void Algo1()
        {
            var algo = new Algo1();

            var res = algo.solution(new int[]{1, 5, 3, 3, 7});
            Assert.IsTrue(res);

            res = algo.solution(new int[] { 1, 3, 5, 3, 4 });
            Assert.IsFalse(res);

            res = algo.solution(new int[] { 1, 3, 5 });
            Assert.IsTrue(res);
        }
    }
}
