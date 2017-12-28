namespace Algo.DynamicProgrammingAdvanced
{
    public class RegexMatching
    {
        public bool regularExpressionMatching(string s, string p)
        {
            var dp = new bool?[p.Length];

            return IsMatch(s, p, s.Length - 1, p.Length - 1, false, ref dp);
        }

        private bool IsMatch(string s, string p, int si, int pi, bool starMatchingEnabled, ref bool?[] dp)
        {
            if (si < 0 && pi < 0) {
                return true;
            }

            if (pi < 0) {
                return false;
            }

            if (p[pi] == '*') {
                return IsMatch(s, p, si, pi - 1, true, ref dp);
            }

            if (starMatchingEnabled) {
                var a = si >= 0 && (p[pi] == s[si] && IsMatch(s, p, si - 1, pi, true, ref dp)); 
                var b = si >= 0 && (p[pi] == '.' && IsMatch(s, p, si - 1, pi, true, ref dp));
                var c = IsMatch(s, p, si, pi - 1, false, ref dp);

                dp[pi] = a || b || c;
            }
            else {
                var a = si >= 0 && (p[pi] == s[si] && IsMatch(s, p, si - 1, pi - 1, false, ref dp));
                var b = (p[pi] == '.' && IsMatch(s, p, si - 1, pi - 1, false, ref dp));
                
                dp[pi] = a || b;
            }

            return dp[pi].Value;
        }
    }
}
