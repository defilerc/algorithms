namespace Algo.DynamicProgrammingAdvanced
{
    public class KPalindrome
    {
        public bool kpalindrome(string s, int k)
        {
            return IsPalindrome(s, k, 0, s.Length - 1);
        }

        private bool IsPalindrome(string s, int k, int start, int end)
        {
            if (start >= end) {
                return true;
            }

            if (s[start] == s[end]) {
                return IsPalindrome(s, k, start + 1, end - 1);
            }

            if (k == 0) {
                return false;
            }

            return IsPalindrome(s, k - 1, start + 1, end) ||
                   IsPalindrome(s, k - 1, start, end - 1);
        }
    }
}
