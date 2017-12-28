namespace Algo.Toptal2
{
    public class Algo1
    {
        public bool solution(int[] A)
        {
            for (var i = 1; i < A.Length; i++) {
                if (A[i] < A[i - 1]) {
                    return LeftSwap(A, i) || RightSwap(A, i);
                }
            }

            return true;
        }

        private bool RightSwap(int[] A, int i)
        {
            var j = i + 1;
            while (j < A.Length)
            {
                if (A[j] > A[i]) {
                    Swap(A, i, j);
                    break;
                }
                j++;
            }
            for (var k = 1; k < A.Length; k++) {
                if (A[k] < A[k - 1]) {
                    return false;
                }
            }

            return true;
        }

        private bool LeftSwap(int[] A, int i)
        {
            var j = i - 1;
            while (j >= 0) {
                if (A[j] > A[i]) {
                    Swap(A, i, j);
                    break;
                }
                j--;
            }
            for (var k = 1; k < A.Length; k++) {
                if (A[k] < A[k - 1]) {
                    return false;
                }
            }

            return true;

        }

        private void Swap(int[] A, int i, int j)
        {
            var tmp = A[i];
            A[i] = A[j];
            A[j] = tmp;
        }
    }
}
