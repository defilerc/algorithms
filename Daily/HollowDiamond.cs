using System;
using System.Collections.Generic;
using System.Linq;

namespace Daily
{
    public class HollowDiamond
    {
        public string hollowDiamond(int n)
        {
            var o = new string[2*n+1];
            var s = 2 * Math.Ceiling((n+0d) / 2) - 1;

            for (var i = 0; i <= n; i++) {
                var l = "";
                for (var j = 0; j <= n + i; j++) {
                    l += j < n - i || Math.Abs(i - n) <= s/2 && Math.Abs(j - n) <= s/2 ? "  " : "* ";
                }
                o[i] = o[2 * n - i] = l;
            }

            return string.Join("", o).TrimEnd();
        }
    }
}
