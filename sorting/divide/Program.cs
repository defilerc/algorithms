int possibleSums(int[] coins, int[] quantity) {
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