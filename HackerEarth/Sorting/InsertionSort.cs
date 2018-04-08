namespace HackerEarth.Sorting
{
    using System;
    using System.Linq;

    public class InsertionSort
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var copy = new int[N];

            Array.Copy(array, copy, N);

            for (var i = 0; i < array.Length; i++) {

                var j = i;
                var tmp = array[j];

                while (j > 0 && tmp < array[j - 1]) {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = tmp;
            }

            Console.Write(string.Join(" ", copy.Select(x => Array.IndexOf(array, x) + 1)));
        }
    }
}
