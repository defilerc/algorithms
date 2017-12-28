using Algo.DynamicProgrammingAdvanced;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.DynamicProgrammingAdvanced
{
    [TestClass]
    public class RegexMatchingTests
    {
        [TestMethod]
        public void RegexMatching()
        {
            var algo = new RegexMatching();
            
            var result = algo.regularExpressionMatching("bb", "b");
            Assert.IsFalse(result);

            result = algo.regularExpressionMatching("zab", "z.*");
            Assert.IsTrue(result);

            result = algo.regularExpressionMatching("caab", "d*c*x*a*b");
            Assert.IsTrue(result);
        }
    }
}
