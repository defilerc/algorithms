namespace Algo.DynamicProgramming
{
    public class MapDecodingAlgo
    {
        public int mapDecoding(string message)
        {
            if (message == "") {
                return 1;
            }

            if (message == "0") {
                return 0;
            }

            var total = new int[message.Length];
            var singles = new int[message.Length];

            total[0] = 1;
            singles[0] = 1;

            for (var i = 1; i < message.Length; i++)
            {
                if (message[i] == '0') {
                    if (message[i - 1] < '1' || message[i - 1] > '2') {
                        return 0;
                    }

                    total[i] = singles[i - 1];
                    singles[i] = 0;
                    continue;
                }

                var lastTwo = int.Parse($"{message[i - 1]}{message[i]}");

                singles[i] = total[i - 1];
                total[i] = (lastTwo >= 1 && lastTwo <= 26)
                    ? total[i - 1] + singles[i - 1]
                    : total[i - 1];

                total[i] %= 1000000007;
            }

            return total[message.Length - 1];
        }
    }
}
