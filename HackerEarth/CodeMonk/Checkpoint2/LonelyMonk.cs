namespace HackerEarth.CodeMonk.Checkpoint2
{
    using System;
    using System.Linq;

    public class LonelyMonk
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            var temp = new long[] { 1, 0 };
            long sum = 0;

            for (var i = 0; i < n; i++) {
                sum = (sum + array[i]) % 2;
                temp[sum]++;
            }

            long even = temp[0] * (temp[0] - 1) / 2;
            long odd = temp[1] * (temp[1] - 1) / 2;

            Console.WriteLine(even + odd);
        }
    }
}
