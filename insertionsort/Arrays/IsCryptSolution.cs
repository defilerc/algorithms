using System;
using System.Collections.Generic;

namespace Algo
{
    public class IsCryptSolution
    {
        public bool isCryptSolution(string[] crypt, char[][] solution) {
            
            var replace = new Dictionary<char, int>();
            for (var i = 0; i < solution.Length; i++) {
                replace.Add(solution[i][0], (int)char.GetNumericValue(solution[i][1]));
            }
   
            var word = new long[3];
            for (var w = 0; w < 3; w++)
            {
                for (var i = 0; i < crypt[w].Length; i++)
                {
                    word[w] += replace[crypt[w][i]] * (long)Math.Pow(10, crypt[w].Length - 1 - i);
                }

                if (word[w].ToString().Length != crypt[w].Length)
                {
                    return false;
                }
            }
                                             
            return word[0] + word[1] == word[2];
        }
    }
}
