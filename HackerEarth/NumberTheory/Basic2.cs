namespace HackerEarth.NumberTheory
{
    using System;

    public class Basic2
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var primes = 0;

            for (var i = 2; i <= N; i++) {
                primes += IsPrime(i);
            }
            Console.WriteLine(primes);
        }

        static int IsPrime(int n)
        {
            for (var i = 2; i * i <= n; ++i) {
                if (n % i == 0) {
                    return 0;
                }
            }

            return 1;
        }
    }
}
