using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class FirstNonRepeatingCharTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new FirstNonRepeatingChar();

            var s = "abacabad";

            var result = algo.firstNotRepeatingCharacter(s);

            s = "abacabaabacaba";

            result = algo.firstNotRepeatingCharacter(s);
        }
    }
}
