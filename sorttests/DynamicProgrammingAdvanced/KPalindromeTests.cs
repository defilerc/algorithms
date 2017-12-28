using System;
using Algo.DynamicProgrammingAdvanced;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.DynamicProgrammingAdvanced
{
    [TestClass]
    public class KPalindromeTests
    {
        [TestMethod]
        public void KPalindrome()
        {
            var algo = new KPalindrome();
            var result = algo.kpalindrome("abrarbra", 1);

            Assert.IsTrue(result);
        }
    }
}
