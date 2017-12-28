using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo
{
    public class SwapLexOrder
    {
        public string swapLexOrder2(string str, int[][] pairs)
        {
            var djsets = new List<SortedSet<int>>();
            var outstr = new StringBuilder(str);

            foreach (var pair in pairs) {
                var existing = djsets.SingleOrDefault(
                    s => s.Contains(pair[0]) || s.Contains(pair[1]));

                if (existing == null) {
                    djsets.Add(new SortedSet<int>(pair));
                } else {
                    existing.Add(pair[0]);
                    existing.Add(pair[1]);
                }
            }

            foreach (var set in djsets) {
                var sstr = "";

                foreach (var index in set) {
                    sstr += outstr[index - 1];
                }

                sstr = new string(sstr.OrderByDescending(s => s).ToArray());

                var j = 0;
                foreach (var index in set) {
                    outstr[index - 1] = sstr[j++];
                }
            }

            return outstr.ToString();
        }
    }
}
