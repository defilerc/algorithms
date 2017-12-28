namespace Algo
{
    public partial class IsListPalindrome
    {
        // Definition for singly-linked list:

        public bool isListPalindrome(ListNode<int> l) {
            var length = 0;
            var head = l;
    
            while (l != null) {
                length++;
                l = l.next;
            }
    
            if (length == 0 || length == 1) {
                return true;
            }
    
            var half = head;
            for (var i = 0; i < (length / 2) - 1; i++) {
                half = half.next;
            }
    
            if (length % 2 != 0) {
                half = half.next;
            }
    
            var cur = half.next;
            ListNode<int> prev = null;

            while (cur != null)
            {
                var next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }

            half.next = prev;
            
            cur = head;
            half = half.next;

            while (cur != null && half != null) {
                if (cur.value != half.value) {
                    return false;
                }
        
                cur = cur.next;
                half = half.next;
            }
    
            return true;
        }
    }
}
