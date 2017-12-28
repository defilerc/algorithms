using System;
using System.Collections.Generic;

namespace Algo.CommonTechniques
{
    public partial class MinSubstringWithAllChars
    {
        public string minSubstringWithAllCharsEfficient(string s, string p)
        {
            if (s == "" || p == "" || s.Length < p.Length) {
                return "";
            }

            var phash = new Dictionary<char, int>();
            var shash = new Dictionary<char, int>();

            for (var i = 0; i < p.Length; i++) {
                phash[p[i]] = phash.ContainsKey(p[i]) ? phash[p[i]] + 1 : 1;
            }

            int cur = 0, startIndex = -1, minLength = Int32.MaxValue;
            var matches = 0;

            for (var j = 0; j < s.Length; j++) {

                shash[s[j]] = shash.ContainsKey(s[j]) ? shash[s[j]] + 1 : 1;

                if ( (phash.ContainsKey(s[j]) && phash[s[j]] > 0) && 
                  shash[s[j]] <= phash[s[j]]) {
                    matches++;
                }

                if (matches == p.Length) {

                    while (!phash.ContainsKey(s[cur]) ||
                        (shash.ContainsKey(s[cur]) && shash[s[cur]] > phash[s[cur]])) {

                        if (shash[s[cur]] > (phash.ContainsKey(s[cur]) ? phash[s[cur]] : 0)) {
                            shash[s[cur]]--;
                        }
                        cur++;
                    }

                    var windowLength = j - cur + 1;
                    
                    if (minLength > windowLength) {
                        minLength = windowLength;
                        startIndex = cur;
                    }
                }
            }

            return startIndex == -1 ? "" : s.Substring(startIndex, minLength);
        }
    }
}
