using System;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class GradingHomeworkTests
    {
        [TestMethod]
        public void GradingHomework()
        {
            var algo = new GradingHomeworkAlgo();
            var result = algo.gradingHomework(new string[][] {
                new String[] {"10 = 4x+2", "2"}
            });

            result = algo.gradingHomework(new string[][] {
                    new String[] {"30=5x", "5"}
                });

            result = algo.gradingHomework(new string[][] {
                    new String[] { "-8=-x-2", "6"}
                });
                
        }
    }
}
