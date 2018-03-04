namespace HackerEarth.FebCircuits
{
    using System;
    using System.Linq;

    public class Problem1
    {
        public static void Main(string[] args)
        {
            var N = Console.ReadLine();
            var D = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var s1 = new Problem1().Solve(D, A);

            Console.WriteLine(2);
            Console.WriteLine($"{s1} {D.Last() - s1}");
        }

        public double Solve(double[] D, int[] A)
        {
            return CalcTeamSums(D[0], D[D.Length - 1], D, A);
        }

        private double CalcTeamSums(double start, double end, double[] D, int[] A)
        {
            double T = (start + end) / 2;

            double team1sum = 0, team2sum = 0;
            for (var i = 0; i < D.Length; i++) {
                if (D[i] < T) {
                    team1sum += A[i] / Math.Log(2 + (T - D[i]));
                }
                else {
                    team2sum += A[i] / Math.Log(2 + (D[i] - T));
                }
            }

            if (Math.Abs(team1sum - team2sum) < Math.Pow(10, -9)) {
                return T;
            }

            if (team1sum < team2sum) {
                return CalcTeamSums(start, T, D, A);
            } else {
                return CalcTeamSums(T, end, D, A);
            }

        }
    }
}
