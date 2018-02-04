using System.Linq;
using System.Numerics;

namespace Daily.Jan
{
    public class LastDigitNonZero
    {
        public int lastDigitDiffZero(long n)
        {
            var d = new [] { 1, 1, 2, 6, 4, 2, 2, 4, 2, 8 };
            
            if (n < 10) {
                return d[n];
            }

            if (n / 10 % 10 % 2 == 0) {
                return 6 * lastDigitDiffZero(n / 5) * d[n % 10] % 10;
            }
                
            return 4 * lastDigitDiffZero(n / 5) * d[n % 10] % 10;
        }
    }
}
