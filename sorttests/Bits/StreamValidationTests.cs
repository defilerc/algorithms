using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Bits
{
    [TestClass]
    public class StreamValidationTests
    {
        [TestMethod]
        public void streamValidation()
        {
            var algo = new StreamValidationAlgo();
            var result = algo.streamValidation(new[] {197, 130, 1});
            
            result = algo.streamValidation(new[] {235, 140, 4});
        }
    }
}
