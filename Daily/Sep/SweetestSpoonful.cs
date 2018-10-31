namespace Daily
{
    public class SweetestSpoonful
    {
        public int[] sweetestSpoonful(int[][] marshmallows, int[][] woodenPieces)
        {
            var sweetness = new int[marshmallows.Length][]; ;

            for (var i = 0; i < marshmallows.Length; i++) {
                sweetness[i] = new int[marshmallows[0].Length];

                for (var j = 0; j < marshmallows[i].Length; j++) {
                    sweetness[i][j] = marshmallows[i][j] - 2 * woodenPieces[i][j];
                }
                System.Console.WriteLine(string.Join(" ", sweetness[i]));
            }

//            return MaxSpoonful(sweetness, 0, 0);

            return new int[] { 1 };
        }
    }
}