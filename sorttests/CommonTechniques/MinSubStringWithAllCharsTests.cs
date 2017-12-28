using Algo.CommonTechniques;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.CommonTechniques
{
    [TestClass]
    public class MinSubStringWithAllCharsTests
    {
        [TestMethod]
        public void MinSubstringWithAllChars()
        {
            var algo = new MinSubstringWithAllChars();

            string result;

            result = algo.minSubstringWithAllCharsEfficient("this is a test string", "tist");
            Assert.AreEqual("t stri", result);

            result = algo.minSubstringWithAllCharsEfficient("adobecodebanc", "abc");
            Assert.AreEqual("banc", result);

            //result = algo.minSubstringWithAllChars("adobecodebanc", "abc");
            //Assert.AreEqual("banc", result);

            //result = algo.minSubstringWithAllChars("ab", "a");
            //result = algo.minSubstringWithAllChars("abc", "c");
            //result = algo.minSubstringWithAllChars("abgdezhuik", "kz");

            //result = algo.minSubstringWithAllChars("abkgzdezhuik", "kz");

        }
    }
}
