using System.Text;

namespace Daily
{
    public class AlmostPalindromeFullSolution
    {
        public bool almostPalindrome(string sampleString)
        {
            var half = sampleString.Length / 2;

            return IsPalindrome(sampleString, half - 1,
                sampleString.Length % 2 == 0 ? half : half + 1, 0);
        }

        bool IsPalindrome(string sampleString, int s, int e, int swaps)
        {
            if (swaps > 2) {
                return false;
            }

            if (s < 0 || e > sampleString.Length) {
                return true;
            }

            return sampleString[s] == sampleString[e] 
                ? IsPalindrome(sampleString, s - 1, e + 1, swaps) 
                : Substitute(sampleString, s, e, swaps);
        }

        bool Substitute(string sampleString, int s, int e, int swaps)
        {
            var solved = false;
            
            for (var i = 0; i < sampleString.Length; i++) {
                if (i >= s && i <= e && (sampleString.Length % 2 == 0 || i != sampleString.Length / 2)) {
                    continue;
                }

                if (sampleString[i] == sampleString[e]) {
                    var swapped = Swap(sampleString, s, i);
                    solved = solved || IsPalindrome(swapped, s - 1, e + 1, swaps + 1);
                } else if (sampleString[i] == sampleString[s]) {
                    var swapped = Swap(sampleString, e, i);
                    solved = solved || IsPalindrome(swapped, s - 1, e + 1, swaps + 1);
                }
            }

            return solved;
        }

        static string Swap(string sampleString, int s, int i)
        {
            var copy = new StringBuilder(sampleString);
            var tmp = copy[i]; copy[i] = copy[s]; copy[s] = tmp;
            return copy.ToString();
        }
    }
}
