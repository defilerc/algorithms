using Algo.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Strings
{
    [TestClass]
    public class FindSubstringTests
    {
        [TestMethod]
        public void FindSubstring()
        {
            var algo = new FindSubstring();

            var t = algo.kmpTable("ABCDABD");
            t = algo.kmpTable("ABACABABC");
            t = algo.kmpTable("PARTICIPATE IN PARACHUTE");

            int result;

            result = algo.findFirstSubstringOccurrenceKMP("ffbefbdbacbccecaceddcbcaeaebfedfcfdbeecffdbbf", "cb");
            Assert.AreEqual(9, result);

            result = algo.findFirstSubstringOccurrenceKMP("abc", "c");
            Assert.AreEqual(2, result);


            result = algo.findFirstSubstringOccurrence2("ffbefbdbacbccecaceddcbcaeaebfedfcfdbeecffdbbf", "cb");
            Assert.AreEqual(9, result);

            result = algo.findFirstSubstringOccurrence2("abc", "c");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CodeFightsBestKmp()
        {
            var algo = new FindSubstringKmp();

            var t = algo.BuildKmpTable("ABCDABD");
            t = algo.BuildKmpTable("ABACABABC");
            t = algo.BuildKmpTable("PARTICIPATE IN PARACHUTE");
        }
    }
}
