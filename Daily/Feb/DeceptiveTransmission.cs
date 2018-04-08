using System;
using System.Linq;

namespace Daily.Feb
{
    public class DeceptiveTransmission
    {
        int k;
        double p = 5;

        public string deceptiveTransmission(string e) => 
            string.Join("", e
                .Select(c => c == '\u202A' ? '0' : c == '\u202D' ? '1' : ' ')
                .Where(c => c != ' ')
                .ToLookup(c => Math.Floor(k++ / p))
                .Select(g => Convert.ToInt32(new string(g.ToArray()), 2))
                .Select(d =>  (char) ('A' + d))
                .Select(d => d == '[' ? ' ' : d)
                .ToArray()).Trim();


        int a = 16, b, i;

        public string deceptiveTransmission_kathogh(string e)
        {
            var z = "";

            for (; i < e.Length; i += 2) {
                if (e[i] != 8234) b += a;
                a /= 2;
                if (a < 1) {
                    z += b > 25 ? ' ' : (char) (b + 65);
                    a = 16;
                    b = 0;
                }
            }

            return z.Trim();
        }
    }
}
