using HackerEarth;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerEarthTests
{
    [TestClass]
    public class PossibleSubsetsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new PossibleSubsets();
            var result = algo.possibleSubsets(new[] {'A', 'B', 'C'});
        }
    }
}
