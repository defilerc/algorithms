using System;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class RoadMapTests
    {
        [TestMethod]
        public void RoadMap()
        {
            var algo = new Roadmap();

            var result = algo.roadmap(new string[][] {
                    new[] {"A", "2017-02-01", "2017-03-01", "Sam", "Evan", "Troy"},
                    new[] {"B", "2017-01-16", "2017-02-15", "Troy"},
                    new[] {"C", "2017-02-13", "2017-03-13", "Sam", "Evan"}
                },
                new string[][] {
                    new[] {"Evan", "2017-03-10"},
                    new[] {"Troy", "2017-02-04"}
                });
        }
    }
}
