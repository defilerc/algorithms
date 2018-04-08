using System.Linq;
using System.Text;

namespace Daily
{
    public class AlmostPalindrome
    {
        public bool almostPalindrome(string s)
        {
            var c = new int[26];
            int m = 0, i = 0, n = s.Length;

            for (; i < n; i++) {
                c[s[i] - 97]++;

                if (i < n/2 && s[i] != s[n - 1 - i]) {
                    m++;
                }
            }

            return c.Count(x => x % 2 == 1) < 2 && m < 5;
        }
    }
}
