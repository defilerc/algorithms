using System;
using Algo.Backtracking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests.Backtracking
{
    [TestClass]
    public class WordBoggleTests
    {
        [TestMethod]
        public void WordBoggle()
        {
            var algo = new WordBoggleAlgo();
            var board = new char[][] {
                new char[] {'W', 'E', 'I', 'R'},
                new char[] {'V', 'A', 'I', 'N'},
                new char[] {'T', 'F', 'C', 'N'},
                new char[] {'P', 'E', 'D', 'E'}
            };
            var words = new[] {
                "ACTS", "ALATE", "ASCI", "ATOM", "ATOMS", "CALL", "CAST", "CASTE", "CATS", "CLAST", "EAST", "EATS",
                "ETAS", "JAIL", "JATO", "JATOS", "JETS", "JETSOM", "JLAO", "LACS", "LACTEAL", "LAIC", "LAICS", "LAST",
                "LATE", "LATS", "LEAL", "LEAS", "LEAST", "LETS", "MOAT", "MOATS", "MOSAIC", "MOST", "MOSTE", "ZONE",
                "FAKE", "SAME", "ACED", "ACINI", "ACNE", "ACNED", "AIRN", "CAFE", "CAIN", "CAIRN", "CATE", "CAVE",
                "CEDE", "CINE", "DECAF", "DECENNIA", "DEFACE", "DEFAT", "DEFI", "DEFINE", "DEFT", "DETAIN", "FACE",
                "FACED", "FACET", "FAIN", "FAIR", "FATE", "FATED", "FETA", "FIAT", "FICE", "FIND", "FINE", "FINED",
                "FINNED", "FIRN", "ICED", "INCEPT", "INIA", "INNED", "NIACIN", "NICE", "NINE", "RICE", "RICED", "RIFE",
                "RIFT", "RIFTED", "RIND", "TACE", "TAIN", "VAIN", "VAIR", "VEIN", "VEINED", "WAFT", "WAFTED", "WAIF",
                "WAIFED", "WAIN", "WAIR", "WAVE", "WEIR"
            };

            var result = algo.wordBoggle(board, words);
        }
    }
}
