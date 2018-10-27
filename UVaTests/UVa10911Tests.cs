namespace UVaTests
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using UVa;
    using Xunit;

    public class UVa10911Tests
    {
        [Fact]
        public void Test1()
        {
            var algo = new UVa10911();

            var min = algo.MinDistance(2, new int[][] {
                new[] {1,1},
                new[] {8,6},
                new[] {6,8},
                new[] {1,3},
            });

            Assert.Equal(4.83, min);

            var txt = File.ReadLines(@"C:\src\algorithms\UVa\bin\Debug\netstandard2.0\input.txt")
               .ToList();

            var i = 0;
            var reses = new List<double>();

            while (i < txt.Count) {
                
                var N = int.Parse(txt[i]);
                var cords = new List<int[]>();

                for (var j = i + 1; j < i + 1 + 2*N; j++) {
                    var cord = txt[j].Split(" ").Skip(1).Select(int.Parse).ToArray();
                    cords.Add(cord);
                }

                i += 2*N + 1;

                var res = algo.MinDistance(N, cords.ToArray());
                reses.Add(res);
            }
        }
    }
}
