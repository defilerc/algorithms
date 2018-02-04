using Algo.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Trees
{
    [TestClass]
    public class FindSubstringsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new FindSubstrings();
            
            var result = algo.findSubstrings(new[] {"Apple", "Melon", "Orange", "Watermelon"},
                new[] {"a", "mel", "lon", "el", "An"});
        }
    }
}
