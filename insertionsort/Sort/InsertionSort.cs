namespace Algo
{
    public class InsertionSort
    {
        public int[] Sort(int[] A)
        {
            for (var i = 1; i < A.Length; i++) {
                for (var j = i - 1; j >= 0; j--) {
                    if (A[j] > A[j+1]) {
                        Swap(A, j, j+1);
                    }
                }
            }

            return A;
        }

        private void Swap(int[] A, int i, int j)
        {
            var tmp = A[i];
            A[i] = A[j];
            A[j] = tmp;
        }
    }
}
