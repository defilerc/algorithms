using System;
using System.Linq;

namespace Daily
{
    public class SumBelowBound
    {
        public int sumBelowBound(int b)
        {
            var n = 1;
            while ((b -= n++) >= 0) ;
            return n;
        }

        public int sumBelowBoundShort2(int b) => (int) (Math.Sqrt(1 + 8 * b)-1) / 2;

    }
}
