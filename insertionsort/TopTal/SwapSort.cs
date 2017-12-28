namespace Algo.TopTal
{
    public class SwapSort
    {
        public bool solution(int[] A)
        {
            for (var i = 1; i < A.Length; i++)
            {
                if (A[i] < A[i - 1])
                {
                    return Swap(A, i, false) || Swap(A, i - 1, true);
                }
            }

            return true;
        }

        private bool Swap(int[] A, int cur, bool searchForward)
        {
            int candidate;

            if (searchForward)
            {
                candidate = cur + 1;

                while (candidate < A.Length && A[cur] >= A[candidate])
                {
                    candidate++;
                }
                candidate--;
                SwapInternal(A, cur, candidate);
            }
            else
            {
                candidate = cur - 1;
                while (candidate > 0 && A[cur] <= A[candidate])
                {
                    candidate--;
                }
                candidate++;
                SwapInternal(A, cur, candidate);
            }

            for (var i = 1; i < A.Length; i++)
            {
                if (A[i] < A[i - 1])
                {
                    SwapInternal(A, candidate, cur);
                    return false;
                }
            }

            return true;
        }

        private void SwapInternal(int[] A, int i, int j)
        {
            var tmp = A[i];
            A[i] = A[j];
            A[j] = tmp;
        }
    }
}
