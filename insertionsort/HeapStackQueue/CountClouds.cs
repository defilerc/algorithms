namespace Algo.HeapStackQueue
{
    public class CountCloudsAlgo
    {
        public int CountClouds(char[][] skyMap)
        {
            var totalClouds = 0;
            for (var i = 0; i < skyMap.Length; i++) {
                for (var j = 0; j < skyMap[0].Length; j++) {
                    totalClouds += CountCloud(skyMap, i, j);
                }
            }

            return totalClouds;
        }

        private int CountCloud(char[][] skyMap, int i, int j)
        {
            if (skyMap[i][j] == '1') {
                MarkCloud(skyMap, i, j);
                return 1;
            }
            
            return 0;
        }

        private void MarkCloud(char[][] skyMap, int i, int j)
        {
            if (i < 0 || j < 0 || i >= skyMap.Length || j >= skyMap[0].Length ||
              skyMap[i][j] != '1') {
                return;
            }
            
            skyMap[i][j] = 'x';

            MarkCloud(skyMap, i+1, j);
            MarkCloud(skyMap, i-1, j);
            MarkCloud(skyMap, i, j+1);
            MarkCloud(skyMap, i, j-1);
        }
    }
}
