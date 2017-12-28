using Algo.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Strings
{
    [TestClass]
    public class ClassifyStringsTests
    {
        [TestMethod]
        public void ClassifyStrings()
        {
            var algo = new ClassifyStringsAlgo();
            var result = "";

            result = algo.classifyStrings("aeu");
            Assert.AreEqual("bad", result);

            result = algo.classifyStrings("a?u");
            Assert.AreEqual("mixed", result);

            result = algo.classifyStrings("aba");
            Assert.AreEqual("good", result);

            result = algo.classifyStrings("typ?asdf?relkhfd");
            Assert.AreEqual("bad", result);

            result = algo.classifyStrings("aa?bbbb");
            Assert.AreEqual("bad", result);

            result = algo.classifyStrings("aa?bbb?a?bbbb");
            Assert.AreEqual("bad", result);
        }
    }
}
