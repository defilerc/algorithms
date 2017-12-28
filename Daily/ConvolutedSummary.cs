using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daily
{
    public class ConvolutedSummaryAlgo
    {
        public string convolutedSummary(string line)
        { 
            var first = new HashSet<char>(new[] {'A', 'B', 'C', 'D', 'E', 'V', 'W', 'X', 'Y', 'Z'});
            var output = new StringBuilder();
            foreach (var c in line) {
                var cu = char.ToUpper(c);
                if (first.Contains(cu)) {
                    output.Append(cu < 'E' ? cu : char.ToLower(cu));
                }
            }

            return output.ToString();
        }

        public string convolutedSummary2(string l) =>
            string.Concat(l.Select(c => c >= 'A' && c <= 'E' || c >= 'a' && c <= 'e' ? char.ToUpper(c) :
                c >= 'V' && c <= 'Z' || c >= 'v' && c <= 'z' ? char.ToLower(c) : '0').Where(c => c != '0'));

        public string convolutedSummaryShort(string s) =>
            (s + (s = " ")).Max(a => s = (s + " ABCDE                vwxyz     "[a % 32]).Trim());

        public string convolutedSummaryShortExplained(string s)
        {
            var x1 = (s + (s = " "));

            var x2 = x1.Max(a => s = (s + " ABCDE                vwxyz     ").Trim());

            var x = x1.Max(a => s = (s + " ABCDE                vwxyz     "[a % 32]).Trim());

            return x;
        }
    }
}
