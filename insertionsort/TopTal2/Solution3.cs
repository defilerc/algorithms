using System.Collections.Generic;

namespace Algo.TopTal2
{
    public class Solution3
    {
        public int solution(string S)
        {
            if (string.IsNullOrWhiteSpace(S)) {
                return 0;
            }

            var pre = new HashSet<string>();
            var post = new HashSet<string>();

            for (var i = 0; i < S.Length - 1; i++) {
                pre.Add(S.Substring(0, i + 1));
                post.Add(S.Substring(S.Length - 1 - i, i + 1));
            }

            var max = "";
            var maxLength = 0;

            foreach (var p in pre) {
                if (post.Contains(p) && p.Length > max.Length) {
                    max = p;
                    maxLength = p.Length;
                }
            }

            return maxLength;
        }
    }
}
