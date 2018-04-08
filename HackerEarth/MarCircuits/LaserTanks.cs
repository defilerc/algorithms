namespace HackerEarth.MarCircuits
{
    using System;
    using System.Linq;

    public class LaserTanks
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var H = new int [n][];
            var V = new int [n][];

            for (var i = 0; i < n; i++) {
                H[i] = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            for (var i = 0; i < n; i++) {
                V[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            var max = MaxPower(n - 1, 0, H, V);
            Console.WriteLine(max);
        }

        public static long MaxPower(int i, int j, int[][] H, int[][] V)
        {
            if (i < 0 || j >= H.Length) {
                return 0;
            }

            if (i == 0 && j == H.Length - 1) {
                return Math.Max(H[i][j], V[i][j]);
            }

            int horizontal = 0, vertical = 0;

            for (var x = j; x < H.Length; x++) {
                horizontal += H[i][x];
            }

            for (var y = i; y >= 0; y--) {
                vertical += V[y][j];
            }

            if (horizontal > vertical) {
                return horizontal + MaxPower(i-1, j, H, V);
            } else if (vertical > horizontal) {
                return vertical + MaxPower(i, j+1, H, V);
            } else {
                return horizontal + Math.Max(
                    MaxPower(i - 1, j, H, V),
                    MaxPower(i, j + 1, H, V));
            }
        }
    }
}
