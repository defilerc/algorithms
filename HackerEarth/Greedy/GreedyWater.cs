namespace HackerEarth.Greedy
{
    using System;
    using System.Linq;

    public class GreedyWater
    {
        public static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            while (t-- > 0) {
                var nx = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int n = nx[0], x = nx[1];

                var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Array.Sort(a);

                int currentWater = 0, totalBottles = 0;

                for (var i = 0; i < a.Length; i++) {
                    if (currentWater + a[i] > x) {
                        break;
                    }
                    currentWater += a[i];
                    totalBottles++;
                }

                Console.WriteLine(totalBottles);
            }
        }
    }
}
