namespace Algo.TopTal2
{
    public class Solution3Correct
    {
        public int solution(string S)
        {
            var max = 0;
            for (var i = 0; i < S.Length; i++) {
                if (S.Substring(S.Length - 1 - i, i) == S.Substring(0, i)) {
                    if (i + 1 > max) {
                        max = i;
                    }
                }
            }

            return max;
        }
    }
}
