using System.Collections.Generic;

namespace Algo
{
    public class GoodSet
    {
        public bool goodSet(int[] someSet) {
    
            var queue = new Queue<int>();
    
            for (var i = 2; i < someSet.Length; i++) {
        
                for (var j = 0; j < i - 1; j++) {
                    queue.Enqueue(someSet[i-1] + someSet[j]);
                }
        
                while (queue.Count > 0) {
                    if (someSet[i] == queue.Peek()) {
                        return false;
                    } 
                    
                    if (someSet[i] > queue.Peek()) {
                        queue.Dequeue();
                    } else {
                        break;
                    }
                }
            }
    
            return true;
        }

    }
}
