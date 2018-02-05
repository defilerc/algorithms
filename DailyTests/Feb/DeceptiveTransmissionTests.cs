using System;
using Daily.Feb;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DailyTests.Feb
{
    [TestClass]
    public class DeceptiveTransmissionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new DeceptiveTransmission();
            var result = algo.deceptiveTransmission(
                "‪T‪h‪i‪s‪ ‭i‪s‪ ‭H‭Q‭.‪ ‪C‭o‭m‪m‪e‪n‪c‪e‪ ‪o‪p‭e‪r‪a‭t‪i‭o‪n‭ ‭C‪O‭B‪R‭A‪.‪ ‭S‪e‪n‭d‭ ‭a‪l‭l‪ ‭u‪n‪i‭t‪s‪ ‭t‭o‪ ‪a‭t‭t‭a‭c‭k‪ ‭t‪h‪e‪ ‭n‭o‪r‪t‪h‪ ‪g‪a‭t‪e‪ ‭a‭t‪ ‪2‭1‪4‪5");

            result = algo.deceptiveTransmission(
                "‭L‪o‪r‭e‭m‪ ‪i‭p‭s‭u‪m‭ ‪d‪o‪l‭o‪r‪ ‭s‪i‭t‭ ‪a‭m‪e‪t‭,‪ ‪c‪o‭n‪s‪e‭c‪t‭e‭t‪u‭r‪ ‪a‪d‪i‭p‭i‪s‪c‭i‪n‪g‪ ‭e‪l‭i‭t‭,‪ ‪s‭e‭d‪ ‪d‪o‪ ‪e‭i‭u‪s‭m‪o‭d‪ ‪t‭e‪m‪p‭o‪r‪ ‪i‭n‪c‭i‭d‭i‭d‭u‪n‭t‪ ‭u‪t‪ ‪l‭a‪b‭o‭r‭e‪ ‪e‪t‭ ‭d‪o‪l‪o‭r‪e‪ ‭m‪a‪g‪n‭a");
        }
    }
}
