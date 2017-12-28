using System.Linq;

namespace Algo.DynamicProgrammingAdvanced
{
    public class LongestIncreasingSubsequence
    {
        public int longestIncreasingSubsequence(int[] sequence)
        {
            var longest = new int[sequence.Length];

            longest[0] = 1;

            for (var i = 1; i < sequence.Length; i++) {
                var max = 0;
                for (var j = i - 1; j >= 0; j--) {
                    
                    if (sequence[i] > sequence[j] && longest[j] > max) {
                        max = longest[j];
                    }
                }

                longest[i] = max + 1;
            }

            return longest.Max();
        }

        public class Sequence
        {
            public int Length { get; set; }
            public int Max { get; set; }

            public override string ToString()
            {
                return $"{Length} (Max: {Max})";
            }
        }

    }
}
