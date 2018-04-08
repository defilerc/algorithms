namespace HackerEarth.Sorting
{
    using System;
    using System.Linq;

    public class CountingSortAlgo
    {
        public static void Main(string[] args) {
            var N = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var aux = new int[100001];
            
            for (var i = 0; i < array.Length; i++) {
                aux[array[i]]++;
            }

            for (var i = 0; i < aux.Length; i++) {
                if (aux[ array[i]] > 0) {
                    Console.WriteLine($"{array[i]} {aux[array[i]]}");
                }
            }
        }
    }
}
