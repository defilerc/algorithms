using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class SweetestSpoonfulTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new SweetestSpoonful();

            algo.sweetestSpoonful(new[] {
                new [] {2,8,3,2}, 
                new [] {8,9,7,5}, 
                new [] {9,10,8,4}, 
                new [] {5,13,9,2}
            }, new [] {
                new [] {3,2,2,1}, 
                new [] {2,2,2,1}, 
                new [] {1,1,3,1}, 
                new [] {3,1,2,2}
            });
        }
    }
}
