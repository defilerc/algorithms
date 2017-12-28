using System.Collections.Generic;
using System.Linq;

namespace Algo
{
    public class PossibleSums
    {
        public int possibleSumsRec(int[] coins, int[] quantity)
        {
            var sums = new HashSet<int>();

            DoAllQuantities(coins, quantity, 0, sums, 0);

            return sums.Count;
        }

        private void DoAllQuantities(int[] coins, int[] quantity, int i, HashSet<int> sums, int sum)
        {
            if (sum > 0) {
                sums.Add(sum);
            }

            if (i == coins.Length) {
                return;
            }

            for (var q = quantity[i]; q >= 0; q--) {
                DoAllQuantities(coins, quantity, i + 1, sums, sum + coins[i] * q);
            }
        }



        public int possibleSums(int[] coins, int[] quantity)
        {
            var total = quantity.Aggregate(1, (x, y) => x * (y+1));
            var coeff = new int[quantity.Length];
            var sums = new HashSet<int>();

            for (var t = 1; t < total; t++) {

                IncreaseCoeff(coeff, quantity);
                
                var sum = coins.Zip(coeff, (x, y) => x * y).Sum();

                sums.Add(sum);
            }

            return sums.Count;
        }

        private void IncreaseCoeff(int[] coeff, int[] quantity)
        {
            var index = 0;
            while (true) {

                if (coeff[index] == quantity[index]) {
                    coeff[index] = 0;

                    index++;
                    continue;
                }

                coeff[index]++;
                break;
            }
        }
    }
}
