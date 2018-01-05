using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class AlmostPalindromeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new AlmostPalindrome();
            var result = false;
            result = algo.almostPalindrome("babababa");
            result = algo.almostPalindrome("acac");
            result = algo.almostPalindrome("abcd");
            result = algo.almostPalindrome("abcbcdf");
            result = algo.almostPalindrome("bba");
            result = algo.almostPalindrome("abcbcdf");
            result = algo.almostPalindrome("abcbcdf");
            Assert.AreEqual(false, result);
        }
    }
}
