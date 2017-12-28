namespace Algo
{
    public class Sudoku
    {
        public bool sudoku2(char[][] grid)
        {
            var N = 9;
            
            for (var i = 0; i < N; i++)
            {
                var rowCount = new byte[N];
                var colCount = new byte[N]; 
                var subgridCount = new byte[N];

                for (var j = 0; j < N; j++)
                {
                    var cur = grid[i][j];

                    if (cur != '.' && ++colCount[cur - '1'] > 1)
                    {
                        return false;
                    }

                    cur = grid[j][i];

                    if (cur != '.' && ++rowCount[cur - '1'] > 1)
                    {
                        return false;
                    }

                    cur = grid[(j / 3) + (3 * (i % 3))]   [ (j % 3) + (3 * (i / 3)) ];

                    if (cur != '.' && ++subgridCount[cur - '1'] > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
