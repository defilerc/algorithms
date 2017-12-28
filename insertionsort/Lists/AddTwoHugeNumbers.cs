namespace Algo
{
    public class AddTwoHugeNumbers
    {
        public ListNode<int> addTwoHugeNumbers(ListNode<int> a, ListNode<int> b) {
    
            var lena = Reverse(ref a);
            var lenb = Reverse(ref b);

            var (max, other) = (lena > lenb) ? (a, b) : (b, a);

            var curmax = max;
            var curother = other;

            while (curmax != null) {

                var hold = (curmax.value + (curother?.value ?? 0)  >= 10000) ? 1 : 0;
        
                curmax.value = (curmax.value + (curother?.value ?? 0)) - (10000 * hold);

                var prev = curmax;
                curmax = curmax.next;
                curother = curother?.next;
        
                if (hold > 0) {
                    if (curmax == null) {
                        curmax = new ListNode<int>() {
                            value = hold
                        };
                        prev.next = curmax;
                    } else {
                        curmax.value += hold;
                    }
                }
            }

            Reverse(ref max);
            return max;
        }

        private int Reverse<T>(ref ListNode<T> list) {
            var length = 0;
    
            var cur = list;
            ListNode<T> prev = null;
    
            while (cur != null) {
                var next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
        
                length++;
            }

            list = prev;
            return length;
        }

    }
}
