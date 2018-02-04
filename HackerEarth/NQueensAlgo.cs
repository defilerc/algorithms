using System;

namespace HackerEarth
{
    public class NQueensAlgo
    {
        public static void Main(string[] args)
        {
            var N = 4;
            var board = new bool[N, N];

            var result = NQueens(board, N);

            if (!result) {
                Console.WriteLine("NO");
                return;
            }

            Console.WriteLine("YES");
            for (var i = 0; i < N; i++) {
                for (var j = 0; j < N; j++) {
                    Console.Write(board[i,j] ? "1" : "0");

                    if (j != N - 1) {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }

        static bool NQueens(bool[,] board, int queens)
        {
            if (queens == 0) {
                return true;
            }

            var N = board.GetLength(0);

            for (var i = 0; i < N; i++) {
                for (var j = 0; j < N; j++) {
                    if (Attacked(board, i, j)) {
                        continue;
                    }

                    board[i, j] = true;

                    if (NQueens(board, queens - 1)) {
                        return true;
                    }

                    board[i, j] = false;
                }
            }

            return false;
        }

        static bool Attacked(bool[,] board, int i, int j)
        {
            var n = board.GetLength(0);

            for (var x = 0; x < n; x++) {
                if (board[i, x] || board[x, j]) {
                    return true;
                }

                for (var y = 0; y < n; y++) {

                    if (x + y == i + j && board[x, y] ||
                        x - y == i - j && board[x, y]) {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
