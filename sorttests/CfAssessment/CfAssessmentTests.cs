using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.CfAssessment
{
    [TestClass]
    public class CfAssessmentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new Algo.CfAssessment.CfAssessment();

            var result = algo.decodeString("4[ab]");
            Assert.AreEqual("abababab", result);

            result = algo.decodeString("2[b3[a]]");
            Assert.AreEqual("baaabaaa", result);

            result = algo.decodeString("z1[y]zzz2[abc]");
            Assert.AreEqual("zyzzzabcabc", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var algo = new Algo.CfAssessment.CfAssessment();

            var result = algo.isLucky(1230);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var algo = new Algo.CfAssessment.CfAssessment();

            var result = algo.newNumeralSystem('F');
        }
    }
}
