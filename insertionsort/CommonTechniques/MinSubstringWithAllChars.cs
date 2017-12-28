using System;
using System.Collections.Generic;
using System.Linq;
using AlgoTests.Trees;

namespace Algo.CommonTechniques
{
    public partial class MinSubstringWithAllChars
    {
        public string minSubstringWithAllChars(string s, string t)
        {
            var solutions = new List<string>();
            Find(s, t, 0, 0, 0, 0 , ref solutions);

            return solutions.Aggregate((min, cur) => min.Length < cur.Length ? min : cur);
        }

        private void Find(string s, string t, int startSearch,
            int start, int end, int charsMatched, ref List<string> solutions)
        {
            if (!t.Any() && !solutions.Contains(s.Substring(start, end - start + 1))) {
                solutions.Add(s.Substring(start, end - start + 1));
                return;
            }

            var cur = startSearch;

            while (cur <= s.Length - 1) {

                if (t.IndexOf(s[cur]) >= 0) {

                    Find(s, t.Remove(t.IndexOf(s[cur]), 1), cur + 1,
                        charsMatched == 0 ? cur : start, cur, charsMatched + 1, ref solutions);

                    Find(s, t, cur + 1,
                        start, end, charsMatched, ref solutions);
                }

                cur++;
            }
        }
    }
}
