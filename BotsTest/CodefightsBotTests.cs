using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BotsTests
{
    [TestClass]
    public class CodefightsBotTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new Bots.CodefightsBot();
            var result = algo.plagiarismCheck(new string[] {
                    "ab = 2",
                    "a = 3",
                    "b = 3 + a",
                    "ba = 1"
                },
                new string[] {
                    "ab = 2",
                    "a = 3",
                    "b = 3 + ab",
                    "a = 1"
                });


        }
    }
}
