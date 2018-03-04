namespace HackerEarth.Searching
{
    using System;
    using System.Linq;

    public class BinarySearchAlgo
    {
        public static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(array);
            var q = int.Parse(Console.ReadLine());

            for (var i = 0; i < q; i++) {
                var query = int.Parse(Console.ReadLine());
                Console.WriteLine($"{BinarySearch(array, query) + 1}");
            }
        }

        private static int BinarySearch(int[] array, int k)
        {
            var low = 0;
            var high = array.Length - 1;

            while (low <= high) {
                var median = (high + low) / 2;

                if (array[median] == k) {
                    return median;
                }

                if (array[median] > k) {
                    high = median - 1;
                }
                else {
                    low = median + 1;
                }
            }

            return -1;
        }
    }
}
