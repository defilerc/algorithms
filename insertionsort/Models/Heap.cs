using System;

namespace Algo
{
    public class Heap
    {
        public int[] Elements { get; set; }
        public int HeapSize { get; set; }

        public Heap(int[] array)
        {
            Elements = array;
            HeapSize = array.Length;
        }

        public void BuildMaxHeap()
        {
            var i = (HeapSize - 1) / 2;

            while (i >= 0) {
                MaxHeapify(i);
                i--;
            }
        }

        public int Left(int i)
        {
            return 2 * i + 1;
        }

        public int Right(int i)
        {
            return 2 * i + 2;
        }

        public int Parent(int i)
        {
            return (i - 1) / 2;
        }

        public void MaxHeapify(int i)
        {
            var left = Left(i);
            var right = Right(i);

            var largest = left < HeapSize && Elements[left] > Elements[i]
                ? left : i;

            if (right < HeapSize && Elements[right] > Elements[largest]) {
                largest = right;
            }

            if (largest != i) {
                var tmp = Elements[i];
                Elements[i] = Elements[largest];
                Elements[largest] = tmp;

                MaxHeapify(largest);
            }
        }

        public int ExtractMax()
        {
            if (HeapSize == 0) {
                throw new ArgumentException();
            }

            // Store the minimum value.
            var root = Elements[0];

            // If there are more than 1 items, move the last item to root
            // and call heapify.
            if (HeapSize > 1)
            {
                Elements[0] = Elements[HeapSize - 1];
                MaxHeapify(0);
            }

            HeapSize--;

            return root;
        }

        public void HeapSort()
        {
            BuildMaxHeap();

            for (var i = Elements.Length - 1; i > 0; i--)
            {
                var tmp = Elements[0];
                Elements[0] = Elements[i];
                Elements[i] = tmp;

                HeapSize--;

                MaxHeapify(0);
            }
        }
    }
}
