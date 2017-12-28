using Algo.HeapStackQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.HeapStackQueue
{
    [TestClass]
    public class DecodeStringTests
    {
        [TestMethod]
        public void DecodeString()
        {
            var algo = new DecodeString();

            var result = algo.decodeString("4[ab]");
            
            result = algo.decodeString("sd2[f2[e]g]i");

            result = algo.decodeString("4[3[ab]]");

            result = algo.decodeString("2[b3[a]]");

            result = algo.decodeString("z1[y]zzz2[abc]");

            result = algo.decodeString("100[codefights]");
        }
    }
}
