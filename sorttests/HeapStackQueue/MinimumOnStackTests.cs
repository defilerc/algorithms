using Algo.HeapStackQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.HeapStackQueue
{
    [TestClass]
    public class MinimumOnStackTests
    {
        [TestMethod]
        public void MinimumOnStack()
        {
            var operations = new string[] {
                "push 10",
                "min",
                "push 5",
                "min",
                "push 8",
                "min",
                "pop",
                "min",
                "pop",
                "min"
            };

            var algo = new MinimumOnStackAlgo();
            
            var result = algo.MinimumOnStack(operations);
        }
        
    }
}
