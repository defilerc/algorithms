using Algo.DynamicProgrammingAdvanced;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.DynamicProgrammingAdvanced
{
    [TestClass]
    public class MaximalSquareTests
    {
        [TestMethod]
        public void MaximalSquare()
        {
            var algo = new MaximalSquare();

            var matrix = new char[][] {
                new char[] {'1', '0', '1', '1', '1'},
                new char[] {'1', '0', '1', '1', '1'},
                new char[] {'1', '1', '1', '1', '1'},
                new char[] {'1', '0', '0', '1', '0'},
                new char[] {'1', '0', '0', '1', '0'}
            };

            var matrix2 = new char[][] {
                new[] {'0', '0', '0', '1'},
                new[] {'1', '1', '0', '1'},
                new[] {'1', '1', '1', '1'},
                new[] {'0', '1', '1', '1'},
                new[] {'0', '1', '1', '1'}
            };

            var result = algo.maximalSquareDp(matrix2);
        }
    }
}
