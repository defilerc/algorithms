using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class IsCryptSolutionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new IsCryptSolution();

            var crypt = new string[] {"SEND", "MORE", "MONEY"};
            var solution = new char[][] { new char[] {'O', '0'},
                new char[]{'M', '1'},
                new char[]{'Y', '2'},
                new char[]{'E', '5'},
                new char[]{'N', '6'},
                new char[]{'D', '7'},
                new char[]{'R', '8'},
                new char[]{'S', '9'}};

            var answer = algo.isCryptSolution(crypt, solution);
            Assert.IsTrue(answer);

            crypt = new[] {"A", "A", "A"};
            solution = new[] {new[] {'A', '0'}};
            answer = algo.isCryptSolution(crypt, solution);
            Assert.IsTrue(answer);

        }
    }
}
