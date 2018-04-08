namespace HackerEarth.Sorting
{
    using System;
    using System.Linq;

    public class QuickSortAlgo
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            QuickSort(array, 0, N - 1);

            Console.WriteLine(string.Join(" ", array));
        }

        private static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end) {
                return;
            }

            var piv = Partition(array, start, end);
            QuickSort(array, start, piv);
            QuickSort(array, piv + 1, end);
        }

        private static int Partition(int[] array, int start, int end)
        {
            var rand = new Random();
            var r = rand.Next(start, end + 1);
            Swap(array, start, r);
            
            var piv = array[start];
            var i = start + 1;

            for (var j = start + 1; j <= end; j++) {
                if (array[j] < piv) {
                    Swap(array, j, i++);
                }
            }

            Swap(array, start, i-1);
            return i-1;
        }

        private static void Swap(int[] array, int i1, int i2)
        {
            var tmp = array[i2];
            array[i2] = array[i1];
            array[i1] = tmp;
        }
    }
}
