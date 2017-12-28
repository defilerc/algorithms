using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Strings
{
    public class FindSubstringKmp
    {
        public int findFirstSubstringOccurrence(string s, string x)
        {
            var table = BuildKmpTable(x);

            var i = 0;
            int m = 0;
            while (i + m < s.Length) {
                if (s[m + i] == x[i]) {
                    if (i == x.Length - 1) {
                        return m;
                    }
                    i++;
                } else {
                    if (table[i] == -1) {
                        m++;
                        i = 0;
                    } else {
                        m += i - table[i];
                        i = table[i];
                    }
                }
            }
            return -1;
        }

        public int[] BuildKmpTable(string x)
        {
            var table = new int[x.Length];
            table[0] = -1;
            var match = 0;
            int i;

            for (i = 1; i < table.Length; i++) {

                table[i] = match;

                if (x[i] == x[match]) {
                    match++;
                } else {
                    match = 0;
                }
            }

            return table;
        }
    }
}
