using System;

namespace Algo.Strings
{
    public class FindSubstring
    {
        public int findFirstSubstringOccurrence(string s, string x)
        {
            return Find(s, 0, x, 0, 0);
        }

        private int Find(string s, int si, string x, int xi, int charsMatched)
        {
            if (si >= s.Length || xi >= x.Length) {
                return charsMatched == x.Length ? si - charsMatched : -1;
            }

            var match = -1;
            if (s[si] == x[xi]) {
                match = Find(s, si + 1, x, xi + 1, charsMatched + 1);

                if (match > -1) {
                    return match;
                }
            }

            var nomatch = Find(s, si + 1, x, xi, 0);

            return Math.Max(match, nomatch);
        }

        public int findFirstSubstringOccurrence2(string s, string x)
        {
            for (var i = 0; i < s.Length - x.Length + 1; i++) {
                if (s[i] == x[0]) {
                    var isMatch = true;
                    for (var xi = 1; xi < x.Length; xi++) {
                        if (s[i + xi] != x[xi]) {
                            isMatch = false;
                        }
                    }
                    if (isMatch) {
                        return i;
                    }
                }
            }
            return -1;
        }

        public int findFirstSubstringOccurrenceKMP(string s, string w)
        {
            int m = 0, i = 0;
            var T = kmpTable(w);

            while (m + i < s.Length) {
                if (w[i] == s[m + i]) {
                    i++;

                    if (i == w.Length) {
                        return m;
                    }
                } else {
                    if (T[i] > -1) {
                        m = m + i - T[i];
                        i = T[i];
                    } else {
                        m = m + i + 1;
                        i = 0;
                    }
                }
            }

            return -1;
        }

        public int[] kmpTable(string w)
        {
            int pos = 1, cnd = 0;

            var T = new int[w.Length];
            T[0] = -1;

            while (pos < w.Length) {
                if (w[pos] == w[cnd]) {
                    T[pos] = T[cnd];
                    pos++;
                    cnd++;
                } else {
                    T[pos] = cnd;
                    cnd = T[cnd];

                    while (cnd >= 0 && w[pos] != w[cnd]) {
                        cnd = T[cnd];
                    }

                    pos++;
                    cnd++;
                }
            }

            return T;
        }
    }
}
