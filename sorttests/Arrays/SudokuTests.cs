using System;
using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class SudokuTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new char[][]
            {
                new char[] {'.', '.', '.', '1', '4', '.', '.', '2', '.'},
                new char[] {'.', '.', '6', '.', '.', '.', '.', '.', '.'},
                new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                new char[] {'.', '.', '1', '.', '.', '.', '.', '.', '.'},
                new char[] {'.', '6', '7', '.', '.', '.', '.', '.', '9'},
                new char[] {'.', '.', '.', '.', '.', '.', '8', '1', '.'},
                new char[] {'.', '3', '.', '.', '.', '.', '.', '.', '6'},
                new char[] {'.', '.', '.', '.', '.', '7', '.', '.', '.'},
                new char[] {'.', '.', '.', '5', '.', '.', '.', '7', '.'}
            };

            var algo = new Sudoku();
            
            var result = algo.sudoku2(a);
        }
    }
}
