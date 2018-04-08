namespace HackerEarth
{
    using System;
    using System.Linq;

    public class MultiDArray
    {
        public static void Main(string[] args)
        {
            var d = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var x = d[0];
            var y = d[1];

            var array = new int[x][];
            var transposed = new int[y][];

            for (var i = 0; i < x; i++) {
                array[i] = new int[y];
                var row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (var j = 0; j < y; j++) {
                    array[i][j] = row[j];
                }
            }

            for (var i = 0; i < y; i++) {
                transposed[i] = new int[x];
                for (var j = 0; j < x; j++) {
                    transposed[i][j] = array[j][i];
                }

                Console.WriteLine(string.Concat(transposed[i].Select(n => $"{n} ")).TrimEnd());
            }
        }
    }
}