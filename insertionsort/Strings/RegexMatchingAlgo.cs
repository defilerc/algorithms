using System.Linq;

namespace Algo.Strings
{
    public class RegexMatchingAlgo
    {
        public bool regexMatching(string pattern, string test)
        {
            if (pattern[0] == '^') {
                for (var i = 1; i < pattern.Length; i++) {
                    if (pattern[i] != test[i - 1]) {
                        return false;
                    }
                }
                return true;
            }

            if (pattern.Last() == '$') {
                for (var i = pattern.Length - 2; i >= 0; i--) {
                    if (pattern[i] != test[i + 1]) {
                        return false;
                    }
                }
                return true;
            }

            var concat = pattern + "$" + test;
            var z = GetZArray(concat);

            for (var i = 0; i < concat.Length; ++i) {
                if (z[i] == pattern.Length) {
                    return true;
                }
            }

            return false;
        }

        int[] GetZArray(string str)
        {
            var z = new int[str.Length];

            int l = 0, r = 0;

            for (var i = 1; i < str.Length; ++i) {
                if (i > r) {
                    l = r = i;

                    while (r < str.Length && str[r - l] == str[r]) {
                        r++;
                    }
                    z[i] = r - l;
                    r--;
                } else {
                    var k = i - l;

                    if (z[k] < r - i + 1) {
                        z[i] = z[k];
                    } else {
                        l = i;
                        while (r < str.Length && str[r - l] == str[r]) {
                            r++;
                        }
                        z[i] = r - l;
                        r--;
                    }
                }
            }

            return z;
        }
    }
}
