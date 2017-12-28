using System;

namespace Algo
{
    public class FirstDuplicate
    {
        public int firstDuplicate(int[] a) {

            for (var i = 0; i < a.Length; i++) {
        
                var smartIndex = Math.Abs(a[i]) - 1;
        
                if (a[smartIndex] < 0) {
                    return Math.Abs(a[i]);
                }
        
                a[smartIndex] = -a[smartIndex];
            }
    
            return -1;
        }
    }
}
