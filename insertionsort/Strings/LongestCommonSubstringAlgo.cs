using System;
using System.Collections.Generic;

namespace Algo.Strings
{
    public class LongestCommonSubstringAlgo
    {
        public int longestCommonSubstring(string s, string t)
        {
            //var lcs = new int[s.Length, t.Length];
            var lcs = new Dictionary<SiTi, int>();
            var max = 0;

            for (var si = 0; si < s.Length; si++) {
                for (var ti = 0; ti < t.Length; ti++) {
                    
                    if (s[si] != t[ti]) {
                        //lcs[si, ti] = 0;
                        continue;
                    }

                    if (si == 0 || ti == 0) {
                        lcs.Add(new SiTi { Si = si, Ti = ti }, 1);
                        //[si, ti] = 1;
                    } else {
                        lcs.TryGetValue(new SiTi { Si = si - 1, Ti = ti - 1 }, out int prev); //.Add(new SiTi {Si = si, Ti = ti}, 1);
                        lcs.Add(new SiTi { Si = si, Ti = ti }, prev + 1);
                    }

                    lcs.TryGetValue(new SiTi {Si = si, Ti = ti}, out int cur);
                    if (cur > max) {
                        max = cur;
                    }
                }
            }

            return max;
        }
    }

    public struct SiTi
    {
        public int Si { get; set; }
        public int Ti { get; set; }

        public override string ToString()
        {
            return $"Si: {Si}, Ti: {Ti}";
        }
    }
}
