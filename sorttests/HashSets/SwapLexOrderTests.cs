using System;
using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class SwapLexOrderTests
    {
        [TestMethod]
        public void SwapLexOrder()
        {
            var algo = new SwapLexOrder();

            var result = algo.swapLexOrder2("abdc", new[] {new[] {1, 4}, new[] {3, 4}});

            result = algo.swapLexOrder2("acxrabdz", new[] {
                new[] {1, 3},
                new[] {6, 8},
                new[] {3, 8},
                new[] {2, 7}
            });

            //var result = algo.swapLexOrder("lvvyfrbhgiyexoirhunnuejzhesylojwbyatfkrv",

            //new[] {
            //    new[] {13,23},
            //    new[] {13,28},
            //    new[] {15,20},
            //    new[] {24,29},
            //    new[] {6,7},
            //    new[] {3,4},
            //    new[] {21,30},
            //    new[] {2,13},
            //    new[] {12,15},
            //    new[] {19,23},
            //    new[] {10,19},
            //    new[] {13,14},
            //    new[] {6,16},
            //    new[] {17,25},
            //    new[] {6,21},
            //    new[] {17,26},
            //    new[] {5,6},
            //    new[] {12,24}
            //});
        }
    }
}
