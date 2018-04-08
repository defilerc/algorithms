namespace HackerEarth.NumberTheory
{
    using System;
    using System.Linq;

    public class Basic
    {
        static long d, x, y;

        public static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long A = array[0], B = array[1], C = array[2], M = array[3];

            var res1 = ModularExponentiation(A, B, M);
            var res2 = ModInverse(C, M);

            Console.WriteLine(res1 * res2 % M);
        }

        static long ModularExponentiation(long x, long n, long M)
        {
            long result = 1;
            while (n > 0) {
                if (n % 2 == 1) {
                    result = (result * x) % M;
                }

                x = (x * x) % M;
                n = n / 2;
            }

            return result;
        }

        static long ModInverse(long A, long M)
        {
            ExtendedEuclid(A, M);
            return (x % M + M) % M; //x may be negative
        }

        static void ExtendedEuclid(long A, long B)
        {
            if (B == 0) {
                d = A;
                x = 1;
                y = 0;
            }
            else {
                ExtendedEuclid(B, A % B);
                var temp = x;
                x = y;
                y = temp - (A / B) * y;
            }
        }
    }
}
