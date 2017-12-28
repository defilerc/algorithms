using Algo.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Strings
{
    [TestClass]
    public class TestJustificationTests
    {
        [TestMethod]
        public void TextJustification()
        {
            var algo = new TextJustificationAlgo();
            string[] result;

            result = algo.textJustification(new [] { "Two", "words."}, 9);

            result = algo.textJustification(new[] {"a", "b", "c", "d", "e"}, 1);

            result = algo.textJustification(new[] {"two", "words."}, 11);
            result = algo.textJustification(new[] {"This", "is", "an", "example", "of", "text", "justification."}, 16);

            result = algo.textJustification(new[] {"this", "is", "a", "line", "which"}, 10);

        }
    }
}
