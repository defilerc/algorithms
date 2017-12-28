using System;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class CountApiTests
    {
        [TestMethod]
        public void CountApi()
        {
            var algo = new CountAPI();

            var result = algo.countAPI(new[] {
                "/project1/subproject1/method1",
                "/project2/subproject1/method1",
                "/project1/subproject1/method1",
                "/project1/subproject2/method1",
                "/project1/subproject1/method2",
                "/project1/subproject2/method1",
                "/project2/subproject1/method1",
                "/project1/subproject2/method1"
            });
        }
    }
}
