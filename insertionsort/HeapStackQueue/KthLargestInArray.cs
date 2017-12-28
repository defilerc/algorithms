namespace Algo.HeapStackQueue
{
    public class KthLargestInArray
    {
        // Function to return k'th smallest element in a given array
        public int FindKthLargestInArray(int[] A, int k)
        {
            var heap = new Heap(A);

            heap.HeapSort();

            return heap.Elements[A.Length - k];

        }
    }
}
