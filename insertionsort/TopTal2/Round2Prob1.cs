namespace Algo.TopTal2
{
    public class Round2Prob1
    {
        public int Domino(string S)
        {
            var tiles = S.Split(',');

            if (tiles.Length == 1) {
                return 1;
            }

            var max = 1;

            for (var i = 1; i < tiles.Length; i++) {
                var cur = FindMax(tiles, i, 1);

                if (cur > max) {
                    max = cur;
                }
            }

            return max;
        }

        private int FindMax(string[] tiles, int i, int max)
        {
            if (i >= tiles.Length) {
                return max;
            }

            var cur = tiles[i].Split('-');
            var prev = tiles[i - 1].Split('-');

            if (cur[0] == prev[1]) {
                return FindMax(tiles, i + 1, max + 1);
            }

            return max;
        }
    }
}
