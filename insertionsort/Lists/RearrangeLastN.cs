namespace Algo
{
    public class RearrangeLastN
    {
        public ListNode<int> rearrangeLastN(ListNode<int> l, int n) {

            if (l == null) {
                return l;
            }
    
            var head = l;
    
            var cur = head;
            var tail = head;
            int length = 0;
    
            while (cur != null) {
                length++;

                tail = cur;
                cur = cur.next;
            }
    
            cur = head;
            int curIndex = 1;
            ListNode<int> newHead = head;
    
            while (cur.next != null) {
                if (curIndex == length - n) {
                    newHead = cur.next;
                    cur.next = null;
                    tail.next = head;
                    break;
                }
                cur = cur.next;
                curIndex++;
            }
    
            return newHead;
        }
    }
}
