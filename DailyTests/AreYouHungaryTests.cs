using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class AreYouHungaryTests

    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new AreYouHungaryAlgo();
            string[] result;

            result = algo.areYouHungary(new[] {"Hayley", "Amy", "Brendan"}, new[] {"Salad"},
                new int[][] {new[] {5}, new[] {8}, new[] {1}});

            result = algo.areYouHungary(new[] {"Jack", "Jeanne"}, new[] {"Pasta", "Chicken"}, new int[][] {
                new[] {3, 4},
                new[] {3, 6}
            });
        }
    }
}
