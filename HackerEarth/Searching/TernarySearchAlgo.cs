namespace HackerEarth.Searching
{
    using System;
    using System.Linq;

    public class TernarySearchAlgo
    {
        public static void Main(string[] args) // unimodal min
        {
            var n = int.Parse(Console.ReadLine());

            for (var x = 0; x < n; x++) {
                var lr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                double l = lr[0];
                double r = lr[1];

                for (var i = 0; i < 200; i++) {
                    var m1 = (2 * l + r) / 3;
                    var m2 = (2 * r + l) / 3;

                    if (Func(m1) < Func(m2)) {
                        r = m2;
                    }
                    else {
                        l = m1;
                    }
                }

                Console.WriteLine($"{Func(l)}");
            }

            double Func(double x)
            {
                return 2 * x * x - 12 * x + 7;
            }
        }

        public static int TernarySearch(string[] args)
        {
            var array = new[] {2, 3, 5, 6, 8, 9, 12, 13, 14};
            var k = 13;
            var low = 0;
            var high = array.Length - 1;

            while (low <= high) {
                var sep = (high - low) / 3;
                
                var m1 = low + sep + 1;
                var m2 = high - sep;

                if (array[m1] == k) {
                    return m1;
                }

                if (array[m2] == k) {
                    return m2;
                }

                if (k < array[m1]) {
                    high = m1 - 1;
                } else if (k > array[m2]) {
                    low = m2 + 1;
                } else {
                    low = m1 + 1;
                    high = m2 - 1;
                }
            }

            return -1;
        }

        public static double UniModalMax(string[] args)
        {
            double l = -100;
            double r = 100;

            for (var i = 0; i < 200; i++) {
                double m1 = (2 * l + r) / 3;
                double m2 = (2 * r + l) / 3;

                if (Func(m1) > Func(m2)) {
                    r = m2;
                } else {
                    l = m1;
                }
            }

            return Func(l);

            double Func(double x)
            {
                return -1 * 1 * x * x + 2 * x + 3;
            }
        }
    }
}
