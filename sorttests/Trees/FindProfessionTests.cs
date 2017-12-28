using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Trees
{
    [TestClass]
    public class FindProfessionTests
    {
        [TestMethod]
        public void FindProfessionTest()
        {
            var algo = new FindProfession();
            var result = algo.findProfession(4, 2);

            Assert.AreEqual("Engineer", result);

            result = algo.findProfession(3, 3);

            Assert.AreEqual("Doctor", result);
        }
    }
}
