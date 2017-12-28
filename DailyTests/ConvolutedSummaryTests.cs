using System;
using Daily;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests
{
    [TestClass]
    public class ConvolutedSummaryTests
    {
        [TestMethod]
        public void ConvolutedSummary()
        {
            var algo = new ConvolutedSummaryAlgo();
            var result = algo.convolutedSummaryShortExplained("Hello World");
        }
    }
}
