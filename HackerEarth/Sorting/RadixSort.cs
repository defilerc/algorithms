namespace HackerEarth.Sorting
{
    using System;
    using System.Linq;

    public class RadixSortAlgo
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var max = array.Max();
            var mul = 1;

            while (max > 0) {
                RadixSort(array, mul);
                Console.WriteLine(string.Join(" ", array));
                max /= 10;
                mul *= 10;
            }
        }

        private static void RadixSort(int[] array, int mul)
        {
            var freq = new int[10];

            for (var i = 0; i < array.Length; i++) {
                freq[array[i] / mul % 10]++;
            }

            for (var i = 1; i < 10; i++) {
                freq[i] += freq[i-1];
            }

            var output = new int[array.Length];

            for (var i = array.Length - 1; i >= 0; i--) {
                output[freq[array[i] / mul % 10] - 1] = array[i];
                freq[array[i] / mul % 10]--;
            }

            Array.Copy(output, array, array.Length);
        }
    }
}
