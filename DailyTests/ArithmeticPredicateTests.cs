using System;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class ArithmeticPredicateTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new ArithmeticPredicate();

            var result = algo.arithmeticPredicate("( 1 + ( 3 * ( 8 / 2 ) / 6 ) ) + 0 - 1 = 2");
            Assert.IsTrue(result);

            result = algo.arithmeticPredicate("( 1 + 2 ) = 3");
            Assert.IsTrue(result);

            result = algo.arithmeticPredicate("( 3 * ( 7 - 1 ) - 6 ) / 3 = 4");
        }
    }
}
