using Algo.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Strings
{
    [TestClass]
    public class LongestCommonSubstringTests
    {
        [TestMethod]
        public void LCSTest()
        {
            var algo = new LongestCommonSubstringAlgo();
            var result = algo.longestCommonSubstring("abcdxyz", "xyzabcd");

            result = algo.longestCommonSubstring("CHZVFRKMLNOZJK",
                "PQPXRJXKITZYXACBHHKICQCOENDTOMFGDWDWFCGPXIQVKUYTDLCGDEWHTACIOHORDTQKVWCSGSPQOQMSBOAGUWN");
        }
    }
}
