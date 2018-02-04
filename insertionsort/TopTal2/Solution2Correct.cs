using System.Collections.Generic;

namespace Algo.TopTal2
{
    public class Solution2Correct
    {
        public int solution(int N)
        {
            if (N == 0) {
                return 1;
            }

            var str = N.ToString();
            var set = new HashSet<string>();

            for (var i = 0; i < str.Length; i++) {
                FindPermutation(str.Remove(i, 1), str[i].ToString(), set);
            }

            return set.Count;
        }

        private void FindPermutation(string remaining, string constructed, HashSet<string> set)
        {
            if (constructed.StartsWith("0")) {
                return;
            }

            if (string.IsNullOrWhiteSpace(remaining)) {
                set.Add(constructed);
                return;
            }

            for (var i = 0; i < remaining.Length; i++) {
                FindPermutation(remaining.Remove(i, 1), constructed + remaining[i], set);
            }
        }
    }
}
