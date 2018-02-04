using System;

namespace HackerEarth
{
    public class CountBitsAlgo
    {
        static void Main(string[] args)
        {
            var T = Int32.Parse(Console.ReadLine());

            for (var i = 0; i < T; i++) {
                var N = int.Parse(Console.ReadLine());
                var count = 0;

                while (N > 0) {
                    N = N & (N - 1);
                    count++;
                }

                Console.WriteLine(count);
            }
        }
    }
}
