using Algo.TopTal2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.TopTal2
{
    [TestClass]
    public class Round2Tests
    {
        [TestMethod]
        public void Problem1()
        {
            var algo = new Round2Prob1();

            var result = algo.Domino("1-1");
            Assert.AreEqual(1, result);

            result = algo.Domino("1-2,1-2");
            Assert.AreEqual(1, result);

            result = algo.Domino("3-2,2-1,1-4,4-4,5-4,4-2,2-1");
            Assert.AreEqual(4, result);

            result = algo.Domino("5-5,5-5,4-4,5-5,5-5,5-5,5-5,5-5,5-5,5-5");
            Assert.AreEqual(7, result);
            result = algo.Domino("1-1,3-5,5-5,5-4,4-2,1-3");
            Assert.AreEqual(4, result);

            result = algo.Domino("1-2,2-2,3-3,3-4,4-5,1-1,1-2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Problem2()
        {
            var algo = new Round2Prob2();

            var result = algo.Capitalize("first, solve the problem.then, write the code.");
            Assert.AreEqual("First, solve the problem. Then, write the code.", result);

            result = algo.Capitalize("this is a test... and another test.");
            Assert.AreEqual("This is a test... And another test.", result);

            result = algo.Capitalize("hello. how are you today? great! i'm fine too.");
            Assert.AreEqual("Hello. How are you today? Great! I'm fine too.", result);

            result = algo.Capitalize("do.or do not.   there is no try.");
            Assert.AreEqual("Do. Or do not. There is no try.", result);

            result = algo.Capitalize("the house is on fire!?run!");
            Assert.AreEqual("The house is on fire!? Run!", result);

            result = algo.Capitalize(
                "the conference has people who have come from Moscow,Idaho;Paris,Texas;London,Ohio; and other places as well.");
            Assert.AreEqual(
                "The conference has people who have come from Moscow, Idaho; Paris, Texas; London, Ohio; and other places as well.",
                result);
        }

    }
}
