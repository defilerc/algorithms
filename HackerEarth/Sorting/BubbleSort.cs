namespace HackerEarth.Sorting
{
    using System;
    using System.Linq;

    public class BubbleSort
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var swaps = 0;

            for (var i = 0; i < N - 1; i++) {
                for (var j = 0; j < N - 1 - i; j++) {
                    if (array[j] > array[j + 1]) {
                        var tmp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tmp;
                        swaps++;
                    }
                }
            }

            Console.WriteLine(swaps);
        }
    }
}
