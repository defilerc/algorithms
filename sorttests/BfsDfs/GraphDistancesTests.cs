using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo.BfsDfs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.BfsDfs
{
    [TestClass]
    public class GraphDistancesTests
    {
        [TestMethod]
        public void GraphDistances()
        {
            var algo = new GraphDistancesAlgo();
            //var g = new int[][] {
            //    new int[] {-1, 3, 2},
            //    new int[] {2, -1, 0},
            //    new int[] {-1, 0, -1}
            //};

            var g = new int[][] { 
                new int[] {-1, 1, 2}, 
                new int[] {0, -1, 3},
                new int[] {0, 0, -1}
                };

            var result = algo.graphDistances(g, 1);
        }
    }
}
