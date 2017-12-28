using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class FirstDuplicateTests
    {
        [TestMethod]
        public void Find()
        {
            var a = new[] {2, 2};
            var dup = new FirstDuplicate();

            var result = dup.firstDuplicate(a);
        }
    }
}
