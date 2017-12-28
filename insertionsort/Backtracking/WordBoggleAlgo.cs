using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo.Backtracking
{
    public class WordBoggleAlgo
    {
        public string[] wordBoggle(char[][] board, string[] words)
        {
            var solutions = new SortedSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var word in words) {
                var wordFound = false;
                for (var i = 0; i < board.Length; i++) {
                    for (var j = 0; j < board[i].Length; j++) {
                        if (wordFound) {
                            continue;
                        }

                        var visited = board.Select(s => s.ToArray()).ToArray();

                        if (FindBoggle(board, word, 0, i, j, visited)) {
                            solutions.Add(word);
                            wordFound = true;
                        };
                    }
                }
            }

            return solutions.ToArray();
        }

        private bool FindBoggle(char[][] board, string word, int index, int i, int j, char[][] visited)
        {
            if (i < 0 || i >= board.Length || 
                j < 0 || j >= board[i].Length || 
                board[i][j] != word[index] || 
                visited[i][j] == '1') {

                return false;
            }

            visited[i][j] = '1';

            if (index == word.Length - 1 && word[index] == board[i][j]) {
                return true;
            }

            return FindBoggle(board, word, index + 1, i + 1, j, visited.Select(s => s.ToArray()).ToArray()) ||
                   FindBoggle(board, word, index + 1, i - 1, j, visited.Select(s => s.ToArray()).ToArray()) ||
                   FindBoggle(board, word, index + 1, i, j + 1, visited.Select(s => s.ToArray()).ToArray()) ||
                   FindBoggle(board, word, index + 1, i, j - 1, visited.Select(s => s.ToArray()).ToArray()) ||
                   FindBoggle(board, word, index + 1, i + 1, j + 1, visited.Select(s => s.ToArray()).ToArray()) ||
                   FindBoggle(board, word, index + 1, i - 1, j - 1, visited.Select(s => s.ToArray()).ToArray()) ||
                   FindBoggle(board, word, index + 1, i + 1, j - 1, visited.Select(s => s.ToArray()).ToArray()) ||
                   FindBoggle(board, word, index + 1, i - 1, j + 1, visited.Select(s => s.ToArray()).ToArray());
        }
    }
}
