using System;

namespace Algo
{
    public class FirstNonRepeatingChar
    {
        public char firstNotRepeatingCharacter(string s) {
    
            var counts = new Counter[26];

            for (var i = 0; i < s.Length; i++) {
                var index = (int) (s[i] - 'a');
        
                counts[index].Count++;
        
                if (counts[index].Count == 1) {
                    counts[index].FirstIndex = i;
                }
            }

            var minIndex = Int32.MaxValue;
            for (var i = 0; i < counts.Length; i++) {
                if (counts[i].Count == 1 && counts[i].FirstIndex < minIndex) {
                    minIndex = counts[i].FirstIndex;
                }
            }
    
            return (minIndex == Int32.MaxValue) 
                ? '_'
                : s[minIndex];
        }

        public struct Counter {
            public int Count;
            public int FirstIndex;
        }

    }

}
