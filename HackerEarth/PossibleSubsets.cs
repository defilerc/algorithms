namespace HackerEarth
{
    public class PossibleSubsets
    {
        public string possibleSubsets(char[] A)
        {
            var s = "";
            var N = A.Length;

            for (int i = 0; i < (1 << N); ++i) {
                for (int j = 0; j < N; ++j)
                    if ( (i & (1 << j)) > 0)
                        s += $"{A[j]} ";
                s += "\n";
            }

            return s;
        }
    }
}
