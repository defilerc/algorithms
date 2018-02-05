namespace HackerEarth.Sorting
{
    using System;
    using System.Linq;

    public class SelectionSort
    {
        static void Main(string[] args)
        {
            var stop = Console.ReadLine().Split(' ').Select(int.Parse).ToArray()[1];
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (var i = 0; i < array.Length -1 && i < stop; i++) {
                
                var min = i;

                for (var j = i + 1; j < array.Length; j++) {
                    if (array[j] < array[min]) {
                        min = j;
                    }
                }

                var tmp = array[min];
                array[min] = array[i];
                array[i] = tmp;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
