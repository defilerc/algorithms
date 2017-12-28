using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class RotateMatrixTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new RotateMatrix();

            var matrix = new int[][] { new []{1, 2, 3}, new [] {4, 5, 6}, new []{7, 8, 9}};

            var result = algo.rotateImage(matrix);

        }
    }
}
