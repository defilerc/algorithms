using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    /// <summary>
    /// Summary description for MinesweeperTests
    /// </summary>
    [TestClass]
    public class MinesweeperTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new MinesweeperAlgo();
            var result = algo.minesweeper(new[] {
                new[] {true, false, false},
                new[] {false, true, false},
                new[] {false, false, false}
            });
        }
    }
}
